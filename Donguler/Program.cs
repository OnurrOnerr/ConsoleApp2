using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Kampı",
                "Programlamaya başlamak için temel kurs",
                "Java",
                "Kırmançi",
                "Geroiç"
            };
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("********");


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.ReadLine();
        }
    }
}
