using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Puan 15'e eşit ve küçük olduğu sürece 1 ve 6 arasında zar atan ve her turu sayan puan 15'den büyük olduğunda duran kaç deneme yaptığını ve toplam puanını ekrana yazdırınız. (console application)
            //    3 zar birbirine eşitse 6 puan.
            //    Herhangi 2 zar birbirine eşitse 2 puan.
            //        Her zar atma işleminde kazandığı puanı da ekrana yazdırınz

            Random random = new Random();
            int zar1, zar2, zar3, denemeSayisi, sayac;
            int score , sonuc = 0;
            denemeSayisi = 1;
            Console.WriteLine("Deneme sayisi :  1");
            while (sonuc <= 15)
            {
                sayac = 0;
                zar1 = random.Next(1, 7);
                zar2 = random.Next(1, 7);
                zar3 = random.Next(1, 7);

                if (zar1 == zar2 && zar1 == zar3)
                {
                    score = 0;
                    score += 6;
                    Console.WriteLine("1. zar : " + zar1 + " ikinci zar : " + zar2 + " ücüncü zar : " + zar3);
                    Console.WriteLine("kazandiginiz skor :" + score);
                    sonuc = score + sonuc;
                    Console.WriteLine("sonuc : " + sonuc);
                    denemeSayisi++;
                    sayac = denemeSayisi + sayac;
                    Console.WriteLine("sayac = " + sayac);
                    Console.WriteLine();
                }
                else if (zar1 == zar2 || zar1 == zar3 || zar2 == zar3)
                {
                    score = 0;
                    score += 2;
                    Console.WriteLine("1. zar : " + zar1 + " ikinci zar : " + zar2 + " ücüncü zar : " + zar3);
                    Console.WriteLine("kazandiginiz skor : " + score);
                    denemeSayisi++;
                    sayac = denemeSayisi + sayac;
                    sonuc = score + sonuc;
                    Console.WriteLine("sayac = " + sayac);
                    Console.WriteLine("sonuc : " + sonuc);
                    Console.WriteLine();
                }
                else
                {
                    score = 0;
                    Console.WriteLine("1. zar : " + zar1 + " ikinci zar : " + zar2 + " ücüncü zar : " + zar3);
                    denemeSayisi++;
                    sayac = denemeSayisi;                   
                    Console.WriteLine("kazandığınız skor : 0 ");
                    Console.WriteLine("sayac = " + sayac);
                    Console.WriteLine("sonuc : " + sonuc);
                    Console.WriteLine();
                }        
                
            }
            Console.WriteLine("Tebrikler :" + denemeSayisi + " kez zar atarak " + sonuc + " puan topladınız ");


            Console.ReadKey();


        }
    }
}
