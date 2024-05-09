using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genetik_algoritma_proje
{
    public class Canli
    {
        public Canli TurnuvaCifti { get; set; }
        public Gen Gen { get; set; }

        public List<Canli> Olustur(int populasyon)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            List<Canli> pop = new List<Canli>();
            for (int i = 0; i < populasyon; i++)
            {
                pop.Add(new Canli() { Gen = new Gen() });
            }
            return pop;
        }
    }
}
