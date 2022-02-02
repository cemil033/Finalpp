namespace FinalProVege
{
    public class Stend
    {
        public string Stname { get; set; }
        public List<Vegtables> vegtables { get; set; }
        public Stend()
        {
            vegtables = new List<Vegtables>();
        }
        public void Sort()
        {            
            vegtables.OrderBy(t => t.VegHali);
            List<Vegtables> vegt=new List<Vegtables>();
            foreach (Vegtables t in vegtables)
            {
                vegt.Add(t);
            }
            foreach (var vegtable in vegt)
            {
                if (vegtable.VegHali == "Curuk" || vegtable.VegHali == "Toksik")
                {
                    vegtables.Remove(vegtable);
                    GStatistika.GAtilanM++;
                    HStatistika.HAtilanM++;
                }
            }
            vegt.Clear();
        }
    }
}
