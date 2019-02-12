using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

    

        public double AreaRetangulo( )
        {
            return Largura * Altura;


        }

        public double PerimetroRetangulo()
        {
            return (2 * (Largura +  Altura));
        }
        public double DiagonalRetangulo()
        {
           
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));

        }

        public override string ToString()
        {
            return "\nArea:"
                + AreaRetangulo().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPerímetro: "
                + PerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDiagonal: "
                + DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture);


        }


    }


}
