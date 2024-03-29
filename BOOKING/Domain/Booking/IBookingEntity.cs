﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKING.Domain.Booking
{
    public interface IBookingEntity
    {
        Guid BookingID { get; set; }
        DateTime StartTid { get; set; }
        DateTime SlutTid { get; set; }

        bool IsOverlapping(List<BookingEntity> otherBookings);
    }
}
