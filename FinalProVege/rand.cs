using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProVege
{
    static public class Gener
    {
        private static string rand;
        private static Random random = new Random();

        public static string Rand { get => rand; set => rand = value; }
        public static Random Random { get => random; set => random = value; }

        public static int Randm(int rnd)
        {
            return Random.Next(0, rnd);
        }
        public static int RandM(int rnd)
        {
            return Random.Next(1, rnd);
        }
    }
}
