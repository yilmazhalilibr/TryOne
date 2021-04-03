using System;
using System.Diagnostics;

namespace TryOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------------------
            /*
            Console.WriteLine("Lütfen Yaşınızı Girin :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen İsminizi Girin");
            string b = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Yaşınız : {0} , İsminiz : {1} " ,a,b);

            Console.ReadKey();
            */
            //--------------------------------------------------------------------------------------------------------------
            /*
            // KULLANICI GİRİŞ SİMİLASYONU
            // ŞİFREYE SAYISAL DEĞER HARİCİ GİRİŞ YAPMAYA ÇALIŞMAK PROGRAMI PATLATIR

            Console.WriteLine("Kullanıcı Adını Girin");
            string a = Console.ReadLine();
            Console.WriteLine("Şifrenizi Girin");
            int passw = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToString("admin") == a)
            {
                if (passw == 1234)
                {
                    Console.WriteLine("Hesaba Başarıyla Giriş Yapıldı!");
                }
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Bir Hesap Girin!");
            }
            Console.ReadKey();
            */
            //--------------------------------------------------------------------------------------------------------------
            /*
            //SWİTCH SİMİLASYONU

            Console.WriteLine("1 ile 4 arası bir sayı girin");
            int pass = Convert.ToInt32(Console.ReadLine());
            
            switch (pass)
            {
                case 1: Console.WriteLine("Doğru sayı 1"); break;
                case 2: Console.WriteLine("Doğru sayı 2"); break;
                case 3: Console.WriteLine("Doğru sayı 3"); break;
                case 4: Console.WriteLine("Doğru sayı 4"); break;

                default:
                    Console.WriteLine("Lütfen Bir Değer Aratın");
                    break;

            }
            Console.ReadKey();
            */
            //--------------------------------------------------------------------------------------------------------------
            /*
            // TEKLİK ÇİFTLİK VS.

            Console.WriteLine("Lütfen Bir Sayı Girin");

            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine("Sayı Tektir.");
            }
            */
            //--------------------------------------------------------------------------------------------------------------
            /*
            //BÜYÜK OLAN SAYIYI BULDURMA SİMİLASYONU

            long sayi, sayi1;

            Console.WriteLine("Sayıları karşılaştırmak için lütfen iki adey sayı girin.");
            sayi = Convert.ToInt64(Console.ReadLine());
            sayi1 = Convert.ToInt64(Console.ReadLine());

            if (sayi<sayi1)
            {
                Console.WriteLine("Büyük Olan {0}" , sayi1);
            }
            else if (sayi1<sayi)
            {
                Console.WriteLine("Büyük Olan {0}", sayi);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayılar girin.");
            }
            */


            //--------------------------------------------------------------------------------------------------------------
            //İNDİRİM SİMİLASYONU
            /*
            
            double x ,y ;

            Console.Write("Lütfen yapılan alışveriş miktarını girin :  ");
            double sayi = Convert.ToDouble(Console.ReadLine());

            if (sayi > 0 && sayi < 201)
            {
                x = sayi * 0.12;
                y = sayi - x;
                Console.WriteLine("İndirimli Fiyat: {0}", y);
            }
            else if (sayi > 200 && sayi < 401)
            {
                x = sayi * 0.25;
                y = sayi - x;
                Console.WriteLine("İndirimli Fiyat: {0}", y);
            }
            else if (sayi > 400 && sayi < 601)
            {
                x = sayi * 0.35;
                y = sayi - x;
                Console.WriteLine("İndirimli Fiyat: {0}", y);
            }
            
            */
            //--------------------------------------------------------------------------------------------------------------

            //Ekranda kare ve dikdörtgenin alan ve çevresini hesaplama
            
            string kareDikdortgen = "", alanCevre = "";
            int a, b, cevre, alan;

            Console.WriteLine("Kare İçin  : 1 ");
            Console.WriteLine("Dikdörtgen İçin : 2 ye Basınız...");
            Console.Write("Seçiminiz (1-2) : ");

            kareDikdortgen = Console.ReadLine();

            if (kareDikdortgen == "1")
            {
                Console.WriteLine("Seçiminiz (1-2) :{0} ", kareDikdortgen);
                Console.WriteLine("Alan Hesabı için (1)");
                Console.WriteLine("Çevre Hesabı için (2) e Basınız...");
                Console.Write("Seçiminiz (1-2) : ");
                alanCevre = Console.ReadLine();
                if (alanCevre == "1")
                {
                    Console.WriteLine("Seçiminiz (1-2) :{0} ", alanCevre);
                    Console.Write("Lütfen Kenarı Girin : ");
                    Console.Write("Seçiminiz (1-2) : ");
                    a = int.Parse(Console.ReadLine());
                    alan = a * a;
                    Console.WriteLine("Karenin Alanı : {0}", alan);

                }
                else if (alanCevre == "2")
                {
                    Console.WriteLine("Seçiminiz (1-2) :{0} ", alanCevre);
                    Console.Write("Lütfen Kenarı Girin : ");
                    a = int.Parse(Console.ReadLine());
                    cevre = 4 * a;
                    Console.WriteLine("Çevresi : {0}", cevre);

                }

            }
            else if (kareDikdortgen == "2")
            {
                Console.WriteLine("Seçiminiz {0} : ", kareDikdortgen);
                Console.WriteLine("Alan Hesabı için 1 ...");
                Console.WriteLine("Çevre Hesabı için 2...");
                Console.Write("Seçiminiz (1-2)");
                alanCevre = Console.ReadLine();

                if (alanCevre == "1")
                {
                    Console.WriteLine("Seçiminiz : {0}", alanCevre);
                    Console.Write("Uzun Kenarı Giriniz : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Kısa Kenarı Giriniz : ");
                    b = int.Parse(Console.ReadLine());
                    alan = a * b;
                    Console.WriteLine("Dikdörtgenin alanı : {0}", alan);
                }
                else if (alanCevre == "2")
                {
                    Console.WriteLine("Seçiminiz : {0}", alanCevre);
                    Console.Write("Uzun Kenarı Giriniz : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Kısa Kenarı Giriniz : ");
                    b = int.Parse(Console.ReadLine());
                    cevre = 2 * (a + b);
                    Console.WriteLine("Dikdörtgenin alanı : {0}", cevre);
                }
            }
            

            Console.ReadKey();
        }
    }
}
