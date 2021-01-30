using Goblinfactory.Delimited;

namespace Goblinfactory.Delimited.Tests
{
    internal class PipeLowerCat
    {
        public string[] Kittens { get; }
        public PipeLowerCat(PipeDelimLower kittens)
        {
            Kittens = kittens;
        }
    }
}

