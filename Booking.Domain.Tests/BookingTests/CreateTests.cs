using System;
using System.Collections.Generic;
using Xunit;

namespace Booking.Domain.Tests.BookingTests
{
    public class CreateTests
    {
        [Fact]
        public void GivenStartTidIsDefault_Then_ThrowExcepton()
        {
            //Arrange
            var sut = new Model.Booking(new DateTime(), DateTime.Now);
            //var expected = true;
            //Act

            var actual = sut.IsOverlapping(new List<Model.Booking>());

            //Assert
            Assert.ThrowsAny<ArgumentException>(() => new Model.Booking(new DateTime(), DateTime.Now));
        }
    }
}
