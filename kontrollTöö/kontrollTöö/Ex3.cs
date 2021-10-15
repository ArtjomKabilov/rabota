using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrollTöö
{
    class Ex3
    {
        public static void Main(string[] args)
        {
            /*Joosepi probleem. Ringis on n inimest. Juht loeb ringis, alustades esimesest, ja kuvab ("täidab") m-nda inimese. 
            Ring on suletud, loendamist jätkatakse pärast "hukatud" järgmisest; see kestab seni, kuni ainult üks inimene jääb "ellu". 
            Leidke ellujäänud isiku number, samuti leidke selline m> 1, mille juures esimene inimene jääb "elavaks" [10].*/

            Console.Write("Kui palju mängijaid peaksin lisama?");
            int n = int.Parse(Console.ReadLine());
            var lst = Enumerable.Range(1, n).ToList();
            Console.Write("Mis arvele?");
            int m = int.Parse(Console.ReadLine());
            int curNum = 0;
            Console.WriteLine(string.Join(" ", lst));
            while (lst.Count > 1)
            {
                curNum = (curNum + m) % lst.Count;
                lst.RemoveAt(curNum);
                Console.WriteLine(string.Join(" ", lst));
            }
            Console.ReadLine();
        }
    }
}
