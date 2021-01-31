using FluentAssertions;
using Goblinfactory.Delimited;
using NUnit.Framework;
using System.Collections.Generic;

namespace Goblinfactory.Delimited.Tests
{
    public class CommaDelimTests
    {
        [Test]
        public void Can_implicitly_create_by_assigning_to_string_and_vice_versa()
        {
            CommaDelim cd = "AB,,cDeF,,a";
            string[] cd2 = cd;
            cd2.Should().BeEquivalentTo(new[] { "AB", "", "cDeF", "", "a" });
        }

        [Test]
        public void Null_converts_to_empty_array()
        {
            var cat1 = new CommaCat((string)null);
            cat1.Kittens.Should().BeEquivalentTo(new string[0]);
        }

        [Test]
        public void empty_string_returns_empty_array()
        {
            var cat = new CommaCat("");
            cat.Kittens.Should().BeEquivalentTo(new string[0]);
        }

        [Test]
        public void spaces_are_trimmed()
        {
            var cat = new CommaCat("123 ,45, 6   ,7");
            cat.Kittens.Should().BeEquivalentTo(new[] { "123", "45", "6", "7" });
        }

        [Test]
        public void Tostring_returns_comma_seperated()
        {
            CommaDelim cd = "123,456";
            cd.Should().BeEquivalentTo(new[] { "123", "456" });
            cd.ToString().Should().Be("123,456");
        }
    }
}

