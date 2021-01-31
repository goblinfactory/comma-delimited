using FluentAssertions;
using Goblinfactory.Delimited;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Goblinfactory.Delimited.Tests
{
    public class PipeDelimLowerTests
    {
        [Test]
        public void Can_implicitly_create_by_assigning_to_string_and_vice_versa()
        {
            PipeDelimLower cd = "AB||cDeF||a";
            // the reason I assing CD to a strin[] below, is to avoid 
            // fluentassertions testing the getEnumerator
            // ...we have a separate test for that below. 
            // I want to test 1 thing at a time in a unit test.
            string[] cd2 = cd;
            cd2.Should().BeEquivalentTo(new[] { "ab", "", "cdef", "", "a" });
        }

        [Test]
        public void empty_string_returns_empty_array()
        {
            var cat = new PipeLowerCat("");
            cat.Kittens.Should().BeEquivalentTo(new string[0]);
        }

        // might relate? need to read more carefully? https://stackoverflow.com/questions/13627956/should-implicit-operators-handle-null
        [Test]
        public void Known_issue_CSharp_cant_convert_null_of_no_type_to_a_random_type_to_trigger_a_possible_implicit_conversation()
        {
            // see test below that passes, because compiler knows in test below that it's a "string" that's null.
            Assert.Throws<NullReferenceException>(() => new PipeLowerCat(null));
        }

        [Test]
        public void Null_converts_to_empty_array()
        {
            string names = null;
            var cat = new PipeLowerCat(names);
            cat.Kittens.Should().BeEquivalentTo(new string[0]);
        }

        [Test]
        public void Tostring_returns_pipe_seperated()
        {
            PipeDelimLower cd = "12 3| aB  |  6";
            cd.ToString().Should().Be("12 3|ab|6");
        }
    }
}

