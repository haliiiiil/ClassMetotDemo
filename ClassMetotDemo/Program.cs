using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.IdNumarasi = 354321;
            musteri1.AdSoyad = "Mesut Özil";
            musteri1.yas = 38;
            musteri1.MailAdresi = "sdfnsşng@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.IdNumarasi = 8794635;
            musteri2.AdSoyad = "RobinWan Persie";
            musteri2.yas = 23;
            musteri2.MailAdresi = "sdjkabv@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.IdNumarasi = 36465131;
            musteri3.AdSoyad = "Falcao";
            musteri3.yas = 67;
            musteri3.MailAdresi = "poweıjf@gmail.com";

            Musteri musteri4 = new Musteri();
            musteri4.IdNumarasi = 76541321;
            musteri4.AdSoyad = "Barbara";
            musteri4.yas = 33;
            musteri4.MailAdresi = "elisfgv@gmail.com";

            Musteri musteri5 = new Musteri();
            musteri5.IdNumarasi = 2487921;
            musteri5.AdSoyad = "Kübra Aydın";
            musteri5.yas = 16;
            musteri5.MailAdresi = "nureanv@gmail.com";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriEkle(musteri5);

            Console.WriteLine("Müşterileri Listele!");
            musteriManager.MusteriListesi(musteriler);

            



        }
    }
}
