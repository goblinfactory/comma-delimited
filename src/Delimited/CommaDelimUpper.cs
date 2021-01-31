namespace Goblinfactory.Delimited
{
    public class CommaDelimUpper : DelimBase
    {
        public CommaDelimUpper(string[] values) : base(values) { }
        public CommaDelimUpper(string values) : base(values.SplitAndTrimUpper(',')) { }
        public override string ToString() => string.Join(",", Values);

        public static implicit operator CommaDelimUpper(string[] text) => new CommaDelimUpper(text);
        public static implicit operator CommaDelimUpper(string text) => new CommaDelimUpper(text.SplitAndTrimUpper(','));
        public static implicit operator string[](CommaDelimUpper pdl) => pdl.Values;
    }
}
