using System;
using Sessao11TratamentoExececoes.Entities.Exceptions;
namespace Sessao11TratamentoExececoes.Entities
{
    class Reservation
    {
        public int RoomNUmber { get; set; }
        public DateTime CheckIn  { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNUmber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainExceptions(" Check-out data must be after check-in date. ");
            }
            RoomNUmber = roomNUmber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;



            if (checkIn < now || checkOut < now)
            {
              throw new DomainExceptions ( "Reservation dates for update must be future dates ");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainExceptions(" Check-out data must be after check-in. ");
            }
            
            CheckIn = checkIn;
            CheckOut = checkOut;
           


        }

        public override string ToString()
        {
            return "Room"
                + RoomNUmber
                + ", check-in:"
                + CheckIn.ToString("dd/MM/yy")
                + CheckOut.ToString("dd/MM/yy")
                + ", "
                + Duration()
                + "nights";
        }



    }
}
