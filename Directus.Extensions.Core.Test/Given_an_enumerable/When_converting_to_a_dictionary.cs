using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Directus.Extensions.Core.Test.Given_an_enumerable
{
    [TestFixture]
    public class When_converting_to_a_dictionary
    {
        [Test]
        public void Then_the_exception_says_what_is_going_on()
        {
            // Arrange
            var values = new[] { "one", "one" };

            // Act
            var exception = Assert.Throws<ArgumentException>(()=>values.ToDictionaryExplicit(v => v, v => v));

            // Assert
            Assert.That(exception.Message,Is.StringContaining("one"));
        }
    }
}