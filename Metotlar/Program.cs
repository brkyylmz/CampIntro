using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product{ };
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açiklama = "Amasya elması";
            urun1.StokAdedi = 50;

            Product urun2 = new Product { };
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Açiklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 96;

            Product[] urunler = new Product[] {urun1, urun2 };

            foreach (Product item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Açiklama);
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("-----------------Metotlar------------------");
            
            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);

        }
    }
}
