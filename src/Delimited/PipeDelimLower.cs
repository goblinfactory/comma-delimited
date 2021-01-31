namespace Goblinfactory.Delimited
{
    public class PipeDelimLower : DelimBase
    {
        public PipeDelimLower(string[] values) : base(values) { }
        public PipeDelimLower(string values) : base(values.SplitAndTrimLower('|')) { }
        public override string ToString() => string.Join("|", Values);

        public static implicit operator PipeDelimLower(string[] text) => new PipeDelimLower(text);
        public static implicit operator PipeDelimLower(string text) => new PipeDelimLower(text.SplitAndTrimLower('|'));
        public static implicit operator string[](PipeDelimLower pdl) => pdl.Values;
    }
}
