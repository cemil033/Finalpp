using FinalProVege;
Dukan Dukan = new() { Balans=300,rating=1};
int pand=0;
while (true)
{
    Console.Clear();
    pand = Gener.Randm(20);
    if (pand == 1)
    {
        Console.WriteLine("Pademiya basladi");
        Thread.Sleep(2000);
        for (int i = 0; i < 7; i++)
        {
            Console.Clear();
            foreach (var item in Dukan.Stendler)
            {
                item.Sort();
            }
            Dukan.TerQoc();
            Console.WriteLine("Pandemiya oldugu ucun hec bir mal satisi olmayib ve mal qebul olunmayib");
            Console.WriteLine($"Atilmis mal deyeri: {GStatistika.GAtilanM}");
            GStatistika.GAtilanM = 0;
            Thread.Sleep(5000);
        }        
        Console.WriteLine("Pandemiya oldugu ucun hec bir mal satisi olmayib ve mal qebul olunmayib");
        Console.WriteLine($"Atilmis mal deyeri: {HStatistika.HAtilanM}");
        HStatistika.HAtilanM=0;
        Console.WriteLine("Pandemiya Bitdi");
        Thread.Sleep(5000);
    }
    else
    {
        for (int i = 0; i < 7; i++)
        {
            Console.Clear();
            Dukan.Malqebulu();
            foreach (var item in Dukan.Stendler)
            {
                if (item != null) { item.Sort(); }
                
            }
            Dukan.TesHald();
            Dukan.Musterigelmesi();
            Dukan.Malalmaq();
            Dukan.TerQoc();
            Console.WriteLine("                  Gunluk Hesabat                 ");
            Console.WriteLine($"Gunluk qazanc: {GStatistika.GQazanc} AZN");
            Console.WriteLine($"Gunluk Musteri: {GStatistika.GMusteri}");
            Console.WriteLine($"Gunluk Atilan mal: {GStatistika.GAtilanM} AZN");
            Console.WriteLine($"Gunluk Satilan mal: {GStatistika.GSatilanM} AZN");
            Console.WriteLine($"Gunluk Yeni mal deyeri: {GStatistika.GYenimallar} AZN");
            Console.WriteLine($"Dukanin Reytinqi:{Dukan.rating}");
            GStatistika.GAtilanM = 0;
            GStatistika.GSatilanM = 0;
            GStatistika.GYenimallar = 0;
            GStatistika.GMusteri = 0;
            GStatistika.GQazanc = 0;
            Thread.Sleep(5000);
        }
        Console.Clear();
        Console.WriteLine("                 Heftelik Hesabat             ");
        Console.WriteLine($"Heftelik Qazanc: {HStatistika.HQazanc} AZN");
        Console.WriteLine($"Heftelik Musteri: {HStatistika.HMusteri}");
        Console.WriteLine($"Heftelik Atilan mal: {HStatistika.HAtilanM}AZN ");
        Console.WriteLine($"Heftelik Satilan mal: {HStatistika.HSatilanM}AZN");
        Console.WriteLine($"Dukanin Reytinqi:{Dukan.rating}");
        Console.WriteLine($"Dukanin Balansi: {Dukan.Balans}");
        HStatistika.HAtilanM = 0;
        HStatistika.HSatilanM = 0;
        HStatistika.HMusteri = 0;
        HStatistika.HQazanc = 0;
        Thread.Sleep(5000);
    }

}