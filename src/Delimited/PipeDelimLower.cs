namespace Goblinfactory.Delimited
{
    public class PipeDelimLower : DelimBase
    {
        public PipeDelimLower(string[] values)
        {
            _values = values;
        }
        public PipeDelimLower(string values)
        {
            _values = values.SplitAndTrimLower('|');
        }

        public static implicit operator PipeDelimLower(string[] text) => new PipeDelimLower(text);
        public static implicit operator PipeDelimLower(string text) => new PipeDelimLower(text.SplitAndTrimLower('|'));
        public static implicit operator string[](PipeDelimLower pdl) => pdl._values;
    }
}
