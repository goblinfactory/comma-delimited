namespace Goblinfactory.Delimited
{
    public class CommaDelimLower : DelimBase
    {
        public CommaDelimLower(string[] values)
        {
            _values = values;
        }

        public CommaDelimLower(string values)
        {
            _values = values.SplitAndTrimLower(',');
        }

        public override string ToString()
        {
            return string.Join(",", _values);
        }

        public static implicit operator CommaDelimLower(string[] text) => new CommaDelimLower(text);
        public static implicit operator CommaDelimLower(string text) => new CommaDelimLower(text.SplitAndTrimLower(','));
        public static implicit operator string[](CommaDelimLower pdl) => pdl._values;
        
    }
}
