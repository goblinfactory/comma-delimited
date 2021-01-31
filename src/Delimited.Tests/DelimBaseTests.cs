using FluentAssertions;
using Goblinfactory.Delimited;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delimited.Tests
{
    public class DelimBaseTests
    {
        [Test]
        public void values_can_be_enumerated()
        {
            var cd = new CommaDelim("12,three,four");
            var items = new List<string>();
            foreach (var c in cd) items.Add(c);
            items.ToArray().Should().BeEquivalentTo(new[] { "12", "three", "four" });
        }

        [Test]
        public void Values_are_indexable()
        {
            var cd = new CommaDelim("12,three,four");
            Assert.True(cd[1] == "three");
        }
    }
}
