using Goblinfactory.Delimited;

namespace Goblinfactory.Delimited.Tests
{
    internal class CommaUpperCat
    {
        public string[] Kittens { get; }
        public CommaUpperCat(CommaDelimUpper kittens)
        {
            Kittens = kittens;
        }
    }
}

