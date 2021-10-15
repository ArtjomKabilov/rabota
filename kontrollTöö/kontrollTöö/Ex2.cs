using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrollTöö
{
    class Ex2
    {
        public static void Main(string[] args)
        {//Loendage K-numbrite ühemõõtmelises massiivis M [] nende elementide arv,
         //mis vastavad tingimusele 0 <M [i] <125. K, M luuakse juhuslikult.
            Random rnd = new Random();
            int K = rnd.Next(-100, 200);
            int[] M = new int[K];
            int count = 0;
            for (int i = 0; i < K; i++)
            {
                M[i] = rnd.Next(-100, 200);
                if (M[i] > 0 && M[i] < 125)
                    count++;
            }
            Console.WriteLine($"K = {K}");
            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
