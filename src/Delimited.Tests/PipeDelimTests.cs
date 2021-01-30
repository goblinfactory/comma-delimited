using FluentAssertions;
using Goblinfactory.Delimited;
using NUnit.Framework;
using System.Collections.Generic;

namespace Goblinfactory.Delimited.Tests
{
    public class PipeDelimTests
    {
        [Test]
        public void Can_implicitly_create_by_assigning_to_string_and_vice_versa()
        {
            PipeDelim cd = "AB||cDeF||a";
            // the reason I assing CD to a strin[] below, is to avoid 
            // fluentassertions testing the getEnumerator
            // ...we have a separate test for that below. 
            // I want to test 1 thing at a time in a unit test.
            string[] cd2 = cd;
            cd2.Should().BeEquivalentTo(new[] { "AB", "", "cDeF", "", "a" });
        }

        [Test]
        public void empty_string_returns_empty_array()
        {
            var cat = new PipeCat("");
            cat.Kittens.Should().BeEquivalentTo(new string[0]);
        }

        [Test]
        public void Null_converts_to_empty_array()
        {
            var cat1 = new PipeCat((string)null);
            cat1.Kittens.Should().BeEquivalentTo(new string[0]);

            var cat2 = new PipeLowerCat((string)null);
            cat2.Kittens.Should().BeEquivalentTo(new string[0]);

            var cat3 = new PipeUpperCat((string)null);
            cat3.Kittens.Should().BeEquivalentTo(new string[0]);
        }

        [Test]
        public void spaces_are_trimmed()
        {
            var cat = new PipeCat("123 |45| 6   | 7");
            cat.Kittens.Should().BeEquivalentTo(new[] { "123", "45", "6", "7" });
        }

        [Test]
        public void upperCase_returns_upper()
        {
            var cat = new PipeUpperCat("cat|in|hat");
            cat.Kittens.Should().BeEquivalentTo(new[] { "CAT", "IN", "HAT" });
        }

        [Test]
        public void lowercase_returns_lower()
        {
            var cat = new PipeLowerCat("cAT|in|HAT");
            cat.Kittens.Should().BeEquivalentTo(new[] { "cat", "in", "hat" });
        }

        [Test]
        public void values_can_be_enumerated()
        {
            var cd = new PipeDelim("12|three||FouR");
            var items = new List<string>();
            foreach (var c in cd) items.Add(c);
            items.ToArray().Should().BeEquivalentTo(new[] { "12", "three", "", "FouR" });
        }
    }
}

