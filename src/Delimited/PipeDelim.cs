namespace Goblinfactory.Delimited
{
    public class PipeDelim : DelimBase
    {
        public PipeDelim(string[] values) {            
            _values = values;
        }

        public PipeDelim(string values)
        {
            _values = values.SplitAndTrim('|');
        }
        public static implicit operator PipeDelim(string[] text) => new PipeDelim(text);
        public static implicit operator PipeDelim(string text) => new PipeDelim(text.SplitAndTrim('|'));
        public static implicit operator string[](PipeDelim pdl) => pdl._values;
    }
}
