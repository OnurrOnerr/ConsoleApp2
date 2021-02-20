using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Onur
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Onur";
            musteri1.Soyadi = "Öner";
            musteri1.TcNo = "123456";

            //KodlamaIo
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12344";
            musteri2.SirketAdi = "KOdelamaIO";
            musteri2.VergiNo = "212121221";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri4);



        }
    }
}
