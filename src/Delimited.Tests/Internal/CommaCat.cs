namespace Goblinfactory.Delimited.Tests
{
    internal class CommaCat
    {
        public string[] Kittens { get; }
        public CommaCat(CommaDelim kittens)
        {
            Kittens = kittens;
        }
    }
}

