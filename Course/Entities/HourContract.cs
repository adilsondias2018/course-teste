using System;


namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date  { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        // Construtor Padrão 

        public HourContract()
        {


        }

        // Sobrecarga do construtor
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }


    }
}
