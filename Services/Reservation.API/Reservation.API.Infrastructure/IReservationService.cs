using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Infrastructure
{
    public interface IReservationService
    {
        public void Create(Reservation.API.Models.Reservation Reservation);

        public Models.Reservation GetReservation();

        public Models.Reservation GetReservationById(Guid Id);
    }
}
