﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[]
            {
                urun1,
                urun2
            };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " / " + urun.Fiyati + " / " + urun.Aciklama);
            }
            
            Console.WriteLine("------------Metodlar---------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            

            sepetManager.Ekle2("Armut","Yeşil",12,10);
            sepetManager.Ekle2("Elma", "Kırmızı", 5,9);
            sepetManager.Ekle2("KArpuz", "Diyarbakır", 43,8);

            Console.ReadLine();
        }
    }
}
