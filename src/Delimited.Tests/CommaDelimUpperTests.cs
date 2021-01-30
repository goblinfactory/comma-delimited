using FluentAssertions;
using Goblinfactory.Delimited;
using NUnit.Framework;
using System.Collections.Generic;

namespace Goblinfactory.Delimited.Tests
{
    public class CommaDelimUpperTests
    {
        [Test]
        public void Can_implicitly_create_by_assigning_to_string_and_vice_versa()
        {
            CommaDelimUpper cd = "AB,,cDeF,,a";
            // the reason I assing CD to a strin[] below, is to avoid 
            // fluentassertions testing the getEnumerator
            // ...we have a separate test for that below. 
            // I want to test 1 thing at a time in a unit test.
            string[] cd2 = cd;
            cd2.Should().BeEquivalentTo(new[] { "AB", "", "CDEF", "", "A" });
        }

        [Test]
        public void empty_string_returns_empty_array()
        {
            var cat = new CommaUpperCat("");
            cat.Kittens.Should().BeEquivalentTo(new string[0]);
        }

        [Test]
        public void upperCase_returns_upper()
        {
            var cat = new CommaUpperCat("cat,in,hat");
            cat.Kittens.Should().BeEquivalentTo(new[] { "CAT", "IN", "HAT" });
        }

        [Test]
        public void Empty_items_are_returned_as_empty_strings()
        {
            CommaDelimUpper cd = "AB,,cDeF,,a";
            cd.Should().BeEquivalentTo(new[] { "AB", "", "CDEF", "", "A" });
            cd.ToString().Should().Be("AB,,CDEF,,A");
        }

        [Test]
        public void Null_converts_to_empty_array()
        {
            var cat3 = new CommaUpperCat((string)null);
            cat3.Kittens.Should().BeEquivalentTo(new string[0]);
        }

        [Test]
        public void Tostring_returns_comma_seperated()
        {
            CommaDelimUpper cd = "AB,cDeF,,a";
            cd.Should().BeEquivalentTo(new[] { "AB", "CDEF", "", "A" });
            cd.ToString().Should().Be("AB,CDEF,,A");
        }

        [Test]
        public void values_can_be_enumerated()
        {
            var cd = new CommaDelimUpper("12,three,,four");
            var items = new List<string>();
            foreach (var c in cd) items.Add(c);
            items.ToArray().Should().BeEquivalentTo(new[] { "12", "THREE", "", "FOUR" });
        }
    }
}

