using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Exceptions
{
    internal class ReservationConflictExceptions : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation IncommingReservation { get; }
        public ReservationConflictExceptions(Reservation existingReservation, Reservation incommingReservation)
        {
            ExistingReservation = existingReservation;
            IncommingReservation = incommingReservation;
        }

        public ReservationConflictExceptions(string? message, Reservation existingReservation, Reservation incommingReservation) : base(message)
        {
            ExistingReservation = existingReservation;
            IncommingReservation = incommingReservation;
        }

        public ReservationConflictExceptions(string? message, Exception? innerException, Reservation existingReservation, Reservation incommingReservation) : base(message, innerException)
        {
            ExistingReservation = existingReservation;
            IncommingReservation = incommingReservation;
        }

    }
}
