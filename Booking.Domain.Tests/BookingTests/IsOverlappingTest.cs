using System;
using Xunit;
using System.Collections.Generic;

namespace Booking.Domain.Tests.BookingTests
{
    public class IsOverlappingTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var sut = new Model.Booking();
            var expected = true;
            //Act

            var actual = sut.IsOverlapping(new List<Model.Booking>());

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GivenBookingsHasOverlaps_ThenThrowFalse()
        {
            // Arrange
            var sut = new Model.Booking(new DateTime(2021, 9, 1), new DateTime(2021, 9, 5));
            var otherBookings = new List<Model.Booking>(new[]
            {
                new Model.Booking(new DateTime(2021,10,1),new DateTime(2021,10,5)) 
            });
            var expected = false;
            // Act
            var actual = sut.IsOverlapping(otherBookings); //not done
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GivenBookingsHasOverlaps2_ThenThrowFalse()
        {
            // Arrange
            var sut = new Model.Booking(new DateTime(2021, 9, 1), new DateTime(2021, 9, 5));
            var otherBookings = new List<Model.Booking>(new[]
            {
                new Model.Booking(new DateTime(2021,9,2),new DateTime(2021,10,6))
            });
            var expected = false;
            // Act
            var actual = sut.IsOverlapping(otherBookings); //not done
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
