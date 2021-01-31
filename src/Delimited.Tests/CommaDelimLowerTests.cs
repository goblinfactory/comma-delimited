using FluentAssertions;
using Goblinfactory.Delimited;
using NUnit.Framework;
using System.Collections.Generic;

namespace Goblinfactory.Delimited.Tests
{
    public class CommaDelimLowerTests
    {
        [Test]
        public void Can_implicitly_create_by_assigning_to_string_and_vice_versa()
        {
            CommaDelimLower cd = "AB,,cDeF,,a";
            string[] cd2 = cd;
            cd2.Should().BeEquivalentTo(new[] { "ab", "", "cdef", "", "a" });
        }
        [Test]
        public void lowercase_returns_lower()
        {
            var cat = new CommaLowerCat("cAT,in,HAT");
            cat.Kittens.Should().BeEquivalentTo(new[] { "cat", "in", "hat" });
        }

        [Test]
        public void Tostring_returns_comma_seperated()
        {
            CommaDelimLower cd = "AB,cDeF,,a";
            cd.Should().BeEquivalentTo(new[] { "ab", "cdef", "", "a" });
            cd.ToString().Should().Be("ab,cdef,,a");
        }
    }
}

