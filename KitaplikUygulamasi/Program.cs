using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitaplikUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine(); //BOŞLUK İÇİN
            Console.WriteLine("**    Geleneksel Kitaplar    **    Klasikler   **");
            Console.WriteLine(); //BOŞLUK İÇİN

            Console.WriteLine("**    1) Çalıkuşu            **    7) Tuna Kılavuzu        **");
            Console.WriteLine();
            Console.WriteLine("**    2) Yaban               **    8) 1984                 **");
            Console.WriteLine();
            Console.WriteLine("**    3) Tutunamayanlar      **    9) Hayvan Çiftliği      **");
            Console.WriteLine();
            Console.WriteLine("**    4) Serenad             **    10) Vadideki Zambak     **");
            Console.WriteLine();
            Console.WriteLine("**    5) Kiralık Konak       **    11) Dava                **");
            Console.WriteLine();
            Console.WriteLine("**    6) Tehlikeli Oyunlar   **    12) Dönüşüm             **");
            Console.WriteLine();

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine();

            Console.WriteLine("****  İşlem Menüsü ****");
            Console.WriteLine();

            Console.WriteLine(" 1- Fiyat Sorgulama");
            Console.WriteLine(" 2- Yeni Okur Kaydı");
            Console.WriteLine(" 3- Günün Kitabı");
            Console.WriteLine(" 4- Kitap Arşivi");
            Console.WriteLine(" 5- Yeni Kitap Satın Al");
            Console.WriteLine(" 6- Tahmin Oyunu");
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemin numarası :  ");

            char islem;
            islem = Convert.ToChar(Console.ReadLine()); //klavyeden girilen değeri chara çevir
            
            if (islem == '1') //1 yazdığımızda fiyat sorgulama gelsin

            {
                Console.WriteLine();
                Console.Write("işlem : Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını giriniz : ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu : 20 TL"); break;
                    case "2": Console.Write("Yaban : 25 TL"); break;
                    case "3": Console.Write("Tutunamayanlar : 40 TL"); break;
                    case "4": Console.Write("Serenad : 35 TL"); break;
                    case "5": Console.Write("Kiralık Konak : 5 TL"); break;
                    case "6": Console.Write("Tehlikeli Oyunlar : 60 TL"); break;
                    case "7": Console.Write("Tuna Kılavuzu : 22 TL"); break;
                    case "8": Console.Write("1984 : 50 TL"); break;
                    case "9": Console.Write("Hayvan Çiftliği  : 28 TL"); break;
                    case "10": Console.Write("Vadideki Zambak : 40 TL"); break;
                    case "11": Console.Write("Dava : 30 TL"); break;
                    case "12": Console.Write("Dönüşüm : 15 TL"); break;
                    default: Console.Write("Böyle bir kitap mevcut değil, numarayı kontrol edin"); break;
                }
            }

            if (islem == '2') 

            {
                Console.WriteLine("**** Yeni Okur Kaydı ****");
                string ad, soyad, universite;
                Console.Write("Adınız :");
                ad = Console.ReadLine();
                Console.Write("Soyadınız :");
                soyad= Console.ReadLine();
                Console.Write("Üniversite : ");
                universite = Console.ReadLine();

                Console.Write(ad +" "+ soyad +" "+ "/" +universite);

                 //dosya oluşturmadan önce bir yerde metin belgesi oluşturup, metin belgesinin özellikler kısmından güvenliğe git dosya yolunu kopyala sonra metni sil ve kopyaladığın dosya yolunu buraya yapıştır

                string dosya = (@"C:\Users\NURGÜL\Desktop\KullanıcıKaydı.txt");
                StreamWriter sw = new StreamWriter(dosya); //dosya oluştururken kullanılan komut
                sw.WriteLine("Adınız :" + ad);
                sw.WriteLine("Soyadınız :" + soyad);
                sw.WriteLine("Üniversite :" + universite);
                sw.Close(); //streamwrite komutunu durdur

            }

            if (islem == '3')

            {
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine();
                Console.WriteLine("Bugünün Kitabı : Tehlikeli Oyunlar");
                Console.WriteLine();
                Console.WriteLine("*************************************");

            }

            if (islem == '4')

            {
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine();

                //Burası Kitap Arşivi.. Burada önce metin belgesi oluştur dosya yolunu belirt.

                FileStream fs = new FileStream(@"C:\Users\NURGÜL\Desktop\Kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin!= null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();

                Console.WriteLine();
                Console.WriteLine("*************************************");
            }

            if (islem == '5')

            {
               for(int i=1; i<=100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarası: ");

                    secim = Console.ReadLine();

                    if (secim=="1")
                    {
                        toplamfiyat = toplamfiyat + 20;
                    }
                    else if(secim=="2")
                    {
                         toplamfiyat = toplamfiyat + 25;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat = toplamfiyat + 40;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat = toplamfiyat + 35;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat = toplamfiyat + 25;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat = toplamfiyat + 60;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat = toplamfiyat + 22;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat = toplamfiyat + 50;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat = toplamfiyat + 28;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat = toplamfiyat + 40;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat = toplamfiyat + 30;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat = toplamfiyat + 15;
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir kitap numarası yok");
                        Console.WriteLine();
                        Console.WriteLine("Başka bir kitap almak ister misiniz? : ");
                        string cevap = Console.ReadLine();

                        if (cevap == "h" || cevap == "H" || cevap == "HAYIR" || cevap == "hayır")
                            break;
                       
                    }
                    Console.WriteLine("Toplam tutar: " + toplamfiyat);
                }
            }

            if (islem == '6')

            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);

                while(sayi != tahmin)
                {
                    Console.Write("Sayı Giriniz : ");
                    tahmin = Convert.ToInt16(Console.ReadLine());

                    if (tahmin > sayi)
                    {
                        Console.Write("Daha Küçük");
                    }
                    if (tahmin < sayi)
                    {
                        Console.Write("Daha Büyük");
                    }
                    if (tahmin == sayi)
                    {
                        Console.Write("Bildiniz Tebriler :) ");
                        break;
                    }
                }

            
            }


            Console.Read();
        }
    }
}