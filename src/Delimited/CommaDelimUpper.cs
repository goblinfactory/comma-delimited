namespace Goblinfactory.Delimited
{
    public class CommaDelimUpper : DelimBase
    {
        public CommaDelimUpper(string[] values)
        {
            _values = values;
        }

        public CommaDelimUpper(string values)
        {
            _values = values.SplitAndTrimUpper(',');
        }

        public override string ToString()
        {
            return string.Join(",", _values);
        }

        public static implicit operator CommaDelimUpper(string[] text) => new CommaDelimUpper(text);
        public static implicit operator CommaDelimUpper(string text) => new CommaDelimUpper(text.SplitAndTrimUpper(','));
        public static implicit operator string[](CommaDelimUpper pdl) => pdl._values;
    }
}
