using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApp1
{
    public class Operaciones
    {
        public double AreaRectangulo(double pbase, double paltura)
        {
            return pbase * paltura;
        }

        public double AreaCirculo(double pradio)
        {
            return Math.Round(Math.PI * (Math.Pow(pradio, 2)), 2);
        }
    }

}
