namespace Goblinfactory.Delimited
{
    public class PipeDelim : DelimBase
    {
        public PipeDelim(string[] values) : base(values) { }
        public PipeDelim(string values) : base(values.SplitAndTrim('|')) { }
        public override string ToString() => string.Join("|", Values);

        public static implicit operator PipeDelim(string[] text) => new PipeDelim(text);
        public static implicit operator PipeDelim(string text) => new PipeDelim(text.SplitAndTrim('|'));
        public static implicit operator string[](PipeDelim pdl) => pdl.Values;
    }
}
