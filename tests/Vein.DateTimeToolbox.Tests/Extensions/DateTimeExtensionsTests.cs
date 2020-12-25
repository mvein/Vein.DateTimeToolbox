using FluentAssertions;
using NUnit.Framework;
using System;
using Vein.DateTimeToolbox.Extensions;

namespace Vein.DateTimeToolbox.Tests.Extensions
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
        [Test]
        public void Yesterday_WhenCalled_ProperDateTimeExpected()
        {
            // ARRANGE
            var dateTime = DateTime.Now;
            var expected = dateTime.AddDays(-1);

            // ACT
            var actual = dateTime.Yesterday();

            // ASSERT
            actual.Should().BeSameDateAs(expected);
        }
    }
}
