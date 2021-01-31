namespace Goblinfactory.Delimited
{
    public class PipeDelimUpper : DelimBase
    {
        public PipeDelimUpper(string[] values) : base(values) { }
        public PipeDelimUpper(string values) : base(values.SplitAndTrimUpper('|')) { }
        public override string ToString() => string.Join("|", Values);

        public static implicit operator PipeDelimUpper(string[] text) => new PipeDelimUpper(text);
        public static implicit operator PipeDelimUpper(string text) => new PipeDelimUpper(text.SplitAndTrimUpper('|'));
        public static implicit operator string[](PipeDelimUpper pdl) => pdl.Values;
    }
}
