using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYUapmisMi = true;

            if (sistemeGirisYUapmisMi==true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            double DolarDun = 7.45;
            double DolarBugun = 7.45;

            if (DolarBugun > DolarDun)
            {
                Console.WriteLine("Dolar Artmış");
            }
            else if (DolarBugun<DolarDun) 
            {
                Console.WriteLine("Dolar Azalmış");
            }
            else
            {
                Console.WriteLine("Dolar Sabit");
            }


            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);
            Console.ReadLine();

        }
        
    }
}
