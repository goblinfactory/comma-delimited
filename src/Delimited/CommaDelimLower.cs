namespace Goblinfactory.Delimited
{
    public class CommaDelimLower : DelimBase
    {
        public CommaDelimLower(string[] values) : base(values){}

        public CommaDelimLower(string values) : base(values.SplitAndTrimLower(',')) { }

        public override string ToString()
        {
            return string.Join(",", Values);
        }

        public static implicit operator CommaDelimLower(string[] text) => new CommaDelimLower(text);
        public static implicit operator CommaDelimLower(string text) => new CommaDelimLower(text.SplitAndTrimLower(','));
        public static implicit operator string[](CommaDelimLower pdl) => pdl.Values;
        
    }
}
