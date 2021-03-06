﻿namespace Goblinfactory.Delimited
{
    public class CommaDelim : DelimBase
    {
        public CommaDelim() : base() { }
        public CommaDelim(string[] values) : base(values) { }

        public CommaDelim(string values) : base(values.SplitAndTrim(',')) { }

        public override string ToString() => string.Join(",", Values);

        public static implicit operator CommaDelim(string[] text) => new CommaDelim(text);
        public static implicit operator CommaDelim(string text) => new CommaDelim(text.SplitAndTrim(','));
        public static implicit operator string[](CommaDelim pdl) => pdl.Values;
    }
}
