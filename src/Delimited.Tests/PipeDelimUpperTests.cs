using FluentAssertions;
using Goblinfactory.Delimited;
using NUnit.Framework;
using System.Collections.Generic;

namespace Goblinfactory.Delimited.Tests
{
    public class PipeDelimUpperTests
    {
        [Test]
        public void Can_implicitly_create_by_assigning_to_string_and_vice_versa()
        {
            PipeDelimUpper cd = "AB||cDeF||a";
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
            var cat = new PipeUpperCat("");
            cat.Kittens.Should().BeEquivalentTo(new string[0]);
        }

        [Test]
        public void Null_converts_to_empty_array()
        {
            var cat3 = new PipeUpperCat((string)null);
            cat3.Kittens.Should().BeEquivalentTo(new string[0]);
        }
        [Test]
        public void Tostring_returns_pipe_seperated()
        {
            PipeDelimLower cd = "12 3| aB  |  6";
            cd.ToString().Should().Be("12 3|AB|6");
        }

    }
}

