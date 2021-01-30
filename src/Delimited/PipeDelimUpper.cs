namespace Goblinfactory.Delimited
{
    public class PipeDelimUpper : DelimBase
    {
        public PipeDelimUpper(string[] values)
        {
            _values = values;
        }

        public PipeDelimUpper(string values)
        {
            _values = values.SplitAndTrimUpper('|');
        }

        public static implicit operator PipeDelimUpper(string[] text) => new PipeDelimUpper(text);
        public static implicit operator PipeDelimUpper(string text) => new PipeDelimUpper(text.SplitAndTrimUpper('|'));
        public static implicit operator string[](PipeDelimUpper pdl) => pdl._values;
    }
}
