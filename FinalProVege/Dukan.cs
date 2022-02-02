using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProVege
{
    static public class Filez
    {
        static public void DukanF(ref Dukan t)
        {
            var str = JsonConvert.SerializeObject(t, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("Dukan.json", str);

        }

        static public void DukanFu(ref Dukan t)
        {

            var jsonStr = File.ReadAllText("Dukan.json");

            t = JsonConvert.DeserializeObject<Dukan>(jsonStr);
        }
        
    }
    public static class GStatistika
    {
        public static int GSatilanM { get; set; }
        public static int GAtilanM { get; set; }
        public static int GMusteri { get; set; }
        public static int GQazanc { get; set; }
        public static int GYenimallar { get; set; }
    }

    public static class HStatistika
    {
        public static int HSatilanM { get; set; }
        public static int HAtilanM { get; set; }
        public static int HMusteri { get; set; }
        public static int HQazanc { get; set; }
    }

    public class Dukan
    {
        public List<Stend> Stendler { get; set; }
        public Queue<Mushteri> Mushteriler { get; set; }
        public int rating { get; set; }
        public int Mushtsay { get; set; }
        public double Balans { get; set; }
        public List<Ishci> Ishciler { get; set; }

        public Dukan()
        {
            Stendler = new List<Stend>();
            Mushteriler = new Queue<Mushteri>();
            Ishciler = new();
        }
        public void Malqebulu()
        {
            List<Vegtables> kartof = new  List<Vegtables>();   
            List<Vegtables> sogan = new   List<Vegtables>();   
            List<Vegtables> kelem = new   List<Vegtables>();   
            List<Vegtables> goyerti = new List<Vegtables>();

            if (Stendler != null)
            {
                if (Stendler.Count == 4)
                {
                    foreach (var item in Stendler[0].vegtables)
                    {
                        kartof.Add(item);
                    }
                    foreach (var item in Stendler[1].vegtables)
                    {
                        sogan.Add(item);
                    }
                    foreach (var item in Stendler[2].vegtables)
                    {
                        kelem.Add(item);
                    }
                    foreach (var item in Stendler[3].vegtables)
                    {
                        goyerti.Add(item);
                    }

                }
                else if (Stendler.Count == 3)
                {
                    foreach (var item in Stendler[0].vegtables)
                    {
                        kartof.Add(item);
                    }
                    foreach (var item in Stendler[1].vegtables)
                    {
                        sogan.Add(item);
                    }
                    foreach (var item in Stendler[2].vegtables)
                    {
                        kelem.Add(item);
                    }

                }
                else if (Stendler.Count == 2)
                {
                    foreach (var item in Stendler[0].vegtables)
                    {
                        kartof.Add(item);
                    }
                    foreach (var item in Stendler[1].vegtables)
                    {
                        sogan.Add(item);
                    }
                }
                else if (Stendler.Count == 1)
                {
                    foreach (var item in Stendler[0].vegtables)
                    {
                        kartof.Add(item);
                    }
                }
                Stendler.Clear();
            }
            else
            {
                Stendler = new();
            }

            if (Balans <= 100&&Balans>=10)
            {
                Stendler.Add(new()
                {
                    Stname = "Kartof",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans/2 - 10); i++)
                {
                    Stendler[0].vegtables.Add(new Vegtables() { VegName = "Kartof", Vegh = Gener.RandM(3), Vegqiymet = 1,Satqiymet=5 });           
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans - 10);
                foreach (var item in kartof)
                {
                    Stendler[0].vegtables.Add(item);
                }
                foreach (var item in Stendler[0].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[0].Sort();
            }
            else if(Balans <= 200 && Balans > 100)
            {
                Stendler.Add(new()
                {
                    Stname = "Kartof",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans/4 - 10); i++)
                {
                    Stendler[0].vegtables.Add(new Vegtables() { VegName = "Kartof", Vegh = Gener.RandM(3), Vegqiymet = 1, Satqiymet = 5 });
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans / 4 - 10);
                foreach (var item in kartof)
                {
                    Stendler[0].vegtables.Add(item);
                }
                foreach (var item in Stendler[0].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[0].Sort();

                Stendler.Add(new()
                {
                    Stname = "Sogan",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans / 4 - 10); i++)
                {
                    Stendler[1].vegtables.Add(new Vegtables() { VegName = "Sogan", Vegh = Gener.RandM(3), Vegqiymet = 1, Satqiymet = 5 });
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans / 4 - 10);
                foreach (var item in sogan)
                {
                    Stendler[1].vegtables.Add(item);
                }
                foreach (var item in Stendler[1].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[1].Sort();
            }
            else if (Balans > 200 && Balans <= 300)
            {
                Stendler.Add(new()
                {
                    Stname = "Kartof",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans / 6 - 10); i++)
                {
                    Stendler[0].vegtables.Add(new Vegtables() { VegName = "Kartof", Vegh = Gener.RandM(3), Vegqiymet = 1,Satqiymet= 5 });
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans / 6 - 10);
                foreach (var item in kartof)
                {
                    Stendler[0].vegtables.Add(item);
                }
                foreach (var item in Stendler[0].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[0].Sort();

                Stendler.Add(new()
                {
                    Stname = "Sogan",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans / 6 - 10); i++)
                {
                    Stendler[1].vegtables.Add(new Vegtables() { VegName = "Sogan", Vegh = Gener.RandM(3), Vegqiymet = 1,Satqiymet= 5 });
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans / 6 - 10);
                foreach (var item in sogan)
                {
                    Stendler[1].vegtables.Add(item);
                }
                foreach (var item in Stendler[1].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[1].Sort();

                Stendler.Add(new()
                {
                    Stname = "Kelem",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans /6 - 10); i++)
                {
                    Stendler[2].vegtables.Add(new Vegtables() { VegName = "Kelem", Vegh = Gener.RandM(3), Vegqiymet = 1,Satqiymet= 5 });
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans / 6 - 10);
                foreach (var item in kelem)
                {
                    Stendler[2].vegtables.Add(item);
                }
                foreach (var item in Stendler[2].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[2].Sort();
            }
            else if (Balans > 300)
            {
                Stendler.Add(new()
                {
                    Stname = "Kartof",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans / 8 - 10); i++)
                {
                    Stendler[0].vegtables.Add(new Vegtables() { VegName = "Kartof", Vegh = Gener.RandM(3), Vegqiymet = 1,Satqiymet= 5 });
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans / 8 - 10);
                foreach (var item in kartof)
                {
                    Stendler[0].vegtables.Add(item);
                }
                foreach (var item in Stendler[0].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[0].Sort();

                Stendler.Add(new()
                {
                    Stname = "Sogan",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans / 8 - 10); i++)
                {
                    Stendler[1].vegtables.Add(new Vegtables() { VegName = "Sogan", Vegh = Gener.RandM(3), Vegqiymet = 1,Satqiymet= 5 });
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans / 8 - 10);
                foreach (var item in sogan)
                {
                    Stendler[1].vegtables.Add(item);
                }
                foreach (var item in Stendler[1].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[1].Sort();

                Stendler.Add(new()
                {
                    Stname = "Kelem",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans / 8 - 10); i++)
                {
                    Stendler[2].vegtables.Add(new Vegtables() { VegName = "Kelem", Vegh = Gener.RandM(3), Vegqiymet = 1,Satqiymet= 5 });
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans / 8 - 10);
                foreach (var item in kelem)
                {
                    Stendler[2].vegtables.Add(item);
                }
                foreach (var item in Stendler[2].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[2].Sort();

                Stendler.Add(new()
                {
                    Stname = "Goyerti",
                    vegtables = new()
                });
                for (int i = 0; i < (int)(Balans / 8 - 10); i++)
                {
                    Stendler[3].vegtables.Add(new Vegtables() { VegName = "Goyerti", Vegh = Gener.RandM(3), Vegqiymet = 1,Satqiymet= 5 });
                    Balans--;
                }
                GStatistika.GYenimallar += (int)(Balans / 8 - 10);
                foreach (var item in goyerti)
                {
                    Stendler[3].vegtables.Add(item);
                }
                foreach (var item in Stendler[3].vegtables)
                {
                    item.Haldeyisme();
                }
                Stendler[3].Sort();
            }
        }
        public void Musterigelmesi()
        {
            for(int i = 0; i < rating * 3; i++)
            {
                Mushteriler.Enqueue(new Mushteri { aldiqlari = new(),maldeyer = 0});                
                GStatistika.GMusteri++;
                HStatistika.HMusteri++;
            }
            rating+=2;
        }

        public void Malalmaq()
        {
            int tok = 0;
            int cur = 0;
            int T = 0;
            for (int m = 0; m < Mushteriler.Count; m++)
            {
                tok = 0;
                cur = 0;
                T = 0;
                for (int i = 0; i < Gener.RandM(10); i++)
                {
                    T = Gener.Randm(Stendler.Count);
                    Mushteriler.First().aldiqlari.Add(Stendler[T].vegtables[0]);
                    Stendler[T].vegtables.Remove(Stendler[T].vegtables[0]);

                }
                foreach (var item in Mushteriler.First().aldiqlari)
                {
                    if (item.VegHali == "Toksik") { tok++; }
                    else if (item.VegHali == "Curuk") { cur++; }

                }
                if (tok == 0)
                {
                    if (cur != 0)
                    {
                        List<Vegtables> list = new List<Vegtables>();
                        foreach (var item in Mushteriler.First().aldiqlari)
                        {
                            list.Add(item);
                        }
                        foreach (var item in list)
                        {
                            if (item.Vegh == 3)
                            {
                                Mushteriler.First().aldiqlari.Remove(item);
                            }
                        }
                        rating--;
                    }
                    foreach (var item in Mushteriler.First().aldiqlari)
                    {
                        Balans += item.Satqiymet;
                        GStatistika.GQazanc++;
                        GStatistika.GMusteri++;
                        HStatistika.HQazanc++;
                        HStatistika.HMusteri++;
                        GStatistika.GSatilanM++;
                        HStatistika.HSatilanM++;
                    }
                }
                else
                {
                    rating--;
                }
                Mushteriler.Dequeue();
                GStatistika.GMusteri++;
                GStatistika.GAtilanM += tok + cur;
                HStatistika.HAtilanM += tok + cur;

            }
        }

        public void Iscigotrmek()
        {
            if(Balans > 300)
            {
                Ishciler.Add(new() { Ishciemekhaqqi = 10 });
            }
        }

        public void TerQoc()
        {
            foreach (var item in Stendler)
            {
                foreach (var item1 in item.vegtables)
                {
                    if (item1.Vegh != 4)
                    {
                        item1.Vegh++;
                        item1.Haldeyisme();
                    }
                }
            }
        }

        public void TesHald()
        {
            foreach (var item in Stendler)
            {
                for (int i = 0; i < 2; i++)
                {
                    int t = Gener.Randm(item.vegtables.Count);
                    item.vegtables[t].Vegh = 4;
                    item.vegtables[t].Haldeyisme();
                }
            }
        }

    }
}
