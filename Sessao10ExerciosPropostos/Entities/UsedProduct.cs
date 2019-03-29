using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Sessao10ExerciosPropostos.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManutactureDate { get; set; }


        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manutactureDate):base (name, price)
        {
            ManutactureDate = manutactureDate;
        }

        public override string etiquetaPreco()
        {
            return Name
                   + Price.ToString("F2", CultureInfo.InvariantCulture)
                   + "(Data Fabricação:"
                   + ManutactureDate.ToString("dd/MM/yyyy")
                   + ")";

        }
    }
}
