using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrollTöö
{
    class Ex1
    {
        public static void Main(string[] args)
        {//Arvestades reaalarvude massiivi, leidke erinevus maksimaalse ja minimaalse arvu vahel.
            var number = new decimal[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Sisestage {i+1} number : ");
                number[i] = Convert.ToDecimal(Console.ReadLine());
            }

            var max = number[0];
            var min = number[0];
            for (int i = 1; i < 10; i++)
            {
                if (number[i] < min) min = number[i];
                if (number[i] > max) max = number[i];
            }

            Console.WriteLine($"{max} - {min} = {max-min}");

            Console.ReadLine();
        }
    }
}
