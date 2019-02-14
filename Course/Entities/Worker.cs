using System;
using Course.Entities.Enums;
using System.Collections.Generic; // namespace da classe list
using System.Text;

namespace Course.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); 


        public Worker()
        {

        }

        // Perceba que logo abaixo, não foi inserido no construtor o contracts, o motivo e toda vez que tiver algo para muitos objetos não se instancia no metodo.
        public Worker(string name, WorkerLevel level, double baseSalary, Department departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract( HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {

            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();

                }
            }

            return sum;

        }


    }
}
