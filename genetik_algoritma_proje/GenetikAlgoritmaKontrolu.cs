using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genetik_algoritma_proje
{
    class GenetikAlgoritmaKontrolu
    {
        public List<Canli> canliList { get; set; } // bireylerin listesi,poplülasyon durumu 
        public List<Canli> elitList { get; set; } // en iyi performans göstere bireyler
        public int elitPop { get; set; } // en iyi özellik gösterenlerin sayısı elit birey sayisi

        public List<Canli> populasyonList //hem canlilari hem elit bireyleri içeren genel pupülasyon her adımda poplsyn. gözlemlemek için
        {
            get
            {
                List<Canli> list = new List<Canli>();
                list.AddRange(canliList);
                if (elitList != null)
                    list.AddRange(elitList);
                return list;
            }
        }

        public GenetikAlgoritmaKontrolu(int pop)
        {
            PopulasyonOlustur(pop);
        }

        private Canli Kiyasla(Canli c1, Canli c2)
        {
            Canli c = new Canli();
            c = c1.Gen.MatyasFormulSkor > c2.Gen.MatyasFormulSkor ? c2 : c1;
            return c;
        }

        public List<Canli> PopulasyonOlustur(int pop) //rastgele genler ile poplsn. 
        {
            List<Canli> liste = new Canli().Olustur(pop);
            canliList = liste;
            return liste;
        }
        public List<Canli> TurnuvaCiftiOlustur()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            List<Canli> TurnuvaList = new List<Canli>();
            for (int i = 0; i < canliList.Count; i++)
            {
                int rndIndis1, rndIndis2;
                rndIndis1 = rnd.Next(0, canliList.Count);
                rndIndis2 = rnd.Next(0, canliList.Count);
                var v1 = canliList[rndIndis1];
                var v2 = canliList[rndIndis2];
                TurnuvaList.Add(Kiyasla(v1, v2));


                rndIndis1 = rnd.Next(0, canliList.Count);
                rndIndis2 = rnd.Next(0, canliList.Count);
                v1 = canliList[rndIndis1];
                v2 = canliList[rndIndis2];
                TurnuvaList[i].TurnuvaCifti = Kiyasla(v1, v2);
            }
            canliList = TurnuvaList;
            return TurnuvaList;
        }


        public List<Canli> Caprazla(double ihtimal)// yeni bireyler
        {

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            Random rnd2 = new Random(Guid.NewGuid().GetHashCode());
            List<Canli> caprazlanmisList = new List<Canli>();

            foreach (var canli in canliList)
            {
                if (rnd2.NextDouble() > ihtimal)
                {
                    caprazlanmisList.Add(canli);
                    continue;
                }

                double rndDouble = rnd.NextDouble();  
                double offspring1a = rndDouble * canli.Gen.x1 + (1 - rndDouble) * canli.TurnuvaCifti.Gen.x1;
                double offspring1b = rndDouble * canli.Gen.x2 + (1 - rndDouble) * canli.TurnuvaCifti.Gen.x2;


                double offspring2a = (1 - rndDouble) * canli.Gen.x1 + rndDouble * canli.TurnuvaCifti.Gen.x1;
                double offspring2b = (1 - rndDouble) * canli.Gen.x2 + rndDouble * canli.TurnuvaCifti.Gen.x2;

                caprazlanmisList.Add(new Canli()
                {
                    Gen = new Gen()
                    {
                        x1 = offspring1a,
                        x2 = offspring1b
                    },
                    TurnuvaCifti = new Canli()
                    {
                        Gen = new Gen()
                        {
                            x1 = offspring2a,
                            x2 = offspring2b
                        }
                    }
                });
            }
            canliList = caprazlanmisList;
            return caprazlanmisList;
        }

        public List<Canli> Mutasyon(double ihtimal)   //genetik çeşitlilik
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            List<Canli> mutasyonList = new List<Canli>();



            foreach (var canli in canliList)
            {
                if (rnd.NextDouble() > ihtimal)
                {
                    mutasyonList.Add(canli);
                    continue;
                }

                mutasyonList.Add(new Canli()
                {
                    Gen = new Gen(),
                    TurnuvaCifti = new Canli() { Gen = new Gen() }
                });
            }

            canliList = mutasyonList;
            return mutasyonList;
        }

        public Canli BestCanli() // en iyi birey
        {
            var c = populasyonList.OrderBy(a => a.Gen.MatyasFormulSkor).FirstOrDefault();
            Console.WriteLine("En iyi Canlı:" + c.Gen.MatyasFormulSkor);
            return c;

        }
        public List<Canli> Elitizm(int elitPop) // en iyi ibrey listesi güncelleme
        {
            List<Canli> elitizm = populasyonList.OrderBy(a => a.Gen.MatyasFormulSkor).Take(elitPop).ToList();
            canliList = populasyonList.OrderBy(a => a.Gen.MatyasFormulSkor).Reverse().Take(populasyonList.Count() - elitPop).ToList();
            elitList = elitizm;
            Console.WriteLine("En iyi Fonsiyon:" + populasyonList.OrderBy(a => a.Gen.MatyasFormulSkor).FirstOrDefault().Gen.MatyasFormulSkor);
            return elitizm;
        }

        public List<Canli> Elitizm()
        {
            return Elitizm(elitPop);
        }
    }
}
