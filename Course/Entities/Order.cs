using System;
using Course.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } // Classe é um enum e vem de outro namespace



        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;

        }


    }
}
