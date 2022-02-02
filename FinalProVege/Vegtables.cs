namespace FinalProVege
{
    public class Vegtables
    {
        public string VegName { get; set; }
        public string VegHali { get; set; }
        public int Vegh { get; set; }
        public double Vegqiymet { get; set; }
        public double Satqiymet { get; set; }

        public override string? ToString()
        {
            return $"{VegName}";
        }

        public void Haldeyisme()
        {
            
            switch (Vegh)
            {
                case 1:
                    VegHali = "Teze";
                    break;
                case 2:
                    VegHali = "Normal";
                    break;
                case 3:
                    VegHali = "Curuk";
                    break;
                case 4:
                    VegHali = "Toksik";
                    break;
                default:
                    break;
            }
        }
    }
   
}

