using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Sessao10ExerciosPropostos.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        // construtor padrão

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string etiquetaPreco()

        {
            return Name
                + "$"
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
