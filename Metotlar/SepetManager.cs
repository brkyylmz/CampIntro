using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Bu metotun kullanımıdır. Pythondaki def mantığıyla aynıdır.
        public void Ekle(Product x)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + x.Adi +" "+ x.StokAdedi + " tane bulunuyor.");
        }

    }
}
