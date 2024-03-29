﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.Booking;
using BOOKING.Domain.Kalender;
using BOOKING.Domain.BookingVindue;
using Microsoft.EntityFrameworkCore;

namespace BOOKING.Persistence.Context
{
    public class BOOKINGContext : DbContext
    {
        public DbSet<BookingEntity> Bookinger { get; set; }
        public DbSet<KalenderEntity> Kalendere { get; set; }
        public DbSet<BookingVindueEntity> BookingVinduer { get; set; }
    }
}