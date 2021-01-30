using Goblinfactory.Delimited;

namespace Goblinfactory.Delimited.Tests
{
    internal class PipeCat
    {
        public string[] Kittens { get; }
        public PipeCat(PipeDelim kittens)
        {
            Kittens = kittens;
        }
    }
}

