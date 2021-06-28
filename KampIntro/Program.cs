using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Type safety = Tip güvenliği
            //Do not repeat yourself = Kendini tekrar etme
            //Alias = Takma isim, değer tutucu

            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            Console.WriteLine(ogrenciSayisi);

            double faizOrani = 1.45;
            Console.WriteLine(faizOrani);

            bool sistemeGirisYapmisMi = true;
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("Eşittir butonu");
            }





        }
    }
}
