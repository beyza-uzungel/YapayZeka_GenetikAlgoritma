using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genetik_algoritma_proje
{
    public class Gen
    {
        public double x1 { get; set; }
        public double x2 { get; set; }

        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public Gen()
        {
            x1 = rnd.NextDouble() * 20 - 10;
            x2 = rnd.NextDouble() * 20 - 10;
        }
        public Gen(double x1, double x2)
        {
            this.x1 = x1;
            this.x2 = x2;
        }
        public double MatyasFormulSkor
        {
            get
            {
                double result = (0.26 * (Math.Pow(x1, 2) + Math.Pow(x2, 2))) - (0.48 * x1 * x2);
                return result;
            }
        }
    }
}
