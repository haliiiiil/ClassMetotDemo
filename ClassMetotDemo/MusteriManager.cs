using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni Eklenen Müsteri:" + musteri.AdSoyad);
        }

        public void MusteriListesi(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("***************");
                Console.WriteLine("ID:" + musteri.IdNumarasi);
                Console.WriteLine("Ad Soyad:" + musteri.AdSoyad);
                Console.WriteLine("Yaşı:" + musteri.yas);
                Console.WriteLine("Mail Adresi:" + musteri.MailAdresi);
                Console.WriteLine("*********************");
            }



           
      

        Console.ReadLine();
            
        }
      



    }
}
