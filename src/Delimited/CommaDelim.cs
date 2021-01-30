namespace Goblinfactory.Delimited
{
    public class CommaDelim : DelimBase
    {
        public CommaDelim(string[] values)
        {
            _values = values;
        }

        public CommaDelim(string values)
        {
            _values = values.SplitAndTrim(',');
        }

        public override string ToString()
        {
            return string.Join(",", _values);
        }

        public static implicit operator CommaDelim(string[] text) => new CommaDelim(text);
        public static implicit operator CommaDelim(string text) => new CommaDelim(text.SplitAndTrim(','));
        public static implicit operator string[](CommaDelim pdl) => pdl._values;
    }
}
