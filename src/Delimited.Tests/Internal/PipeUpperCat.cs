using Goblinfactory.Delimited;

namespace Goblinfactory.Delimited.Tests
{
    internal class PipeUpperCat
    {
        public string[] Kittens { get; }
        public PipeUpperCat(PipeDelimUpper kittens)
        {
            Kittens = kittens;
        }
    }
}

