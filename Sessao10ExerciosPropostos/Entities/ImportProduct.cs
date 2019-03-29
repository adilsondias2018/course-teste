using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sessao10ExerciosPropostos.Entities;
using System.Globalization;
  

namespace Sessao10ExerciosPropostos.Entities
{
    class ImportProduct : Product 
    {
        public double CustomsFree { get; set; }


        public ImportProduct()
        {

        }

        public ImportProduct(string name, double price, double customsFree) : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public override string etiquetaPreco()
        {
            return Name
                + "$"
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + "Preço alfandega: $"
                + CustomsFree.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
                

        }

        public double totalPrice()
        {
            return Price + CustomsFree;



        }
    }
}
