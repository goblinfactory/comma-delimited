using Goblinfactory.Delimited;

namespace Goblinfactory.Delimited.Tests
{
    internal class CommaLowerCat
    {
        public string[] Kittens { get; }
        public CommaLowerCat(CommaDelimLower kittens)
        {
            Kittens = kittens;
        }
    }
}

