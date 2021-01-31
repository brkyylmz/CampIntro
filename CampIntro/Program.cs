using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYaptıMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");     
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirişYaptıMı == true)
            {
                Console.WriteLine("Sisteme başarılı bir şekilde giriş yapıldı.");

            }
            else
            {
                Console.WriteLine("Sisteme giriş yapınız.");
            }


            Console.WriteLine(kategoriEtiketi);
        }
    }
    
}
