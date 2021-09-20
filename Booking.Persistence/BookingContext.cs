using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Booking.Persistence
{
    class BookingContext : DbContext
    {
        public DbSet<Domain.Model.Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PK, FK...
        }
    }
}
