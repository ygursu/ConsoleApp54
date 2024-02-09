using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedengirilensayininhangiayaait
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Int32.Parse(Console.ReadLine());

            if (sayi == 1)
            {
                Console.WriteLine("Ocak");
            }
            else if (sayi == 2)
            {
                Console.WriteLine("Şubat");
            }
            else if (sayi == 3)
            {
                Console.WriteLine("Mart");
            }
            else if (sayi == 4)
            {
                Console.WriteLine("Nisan");
            }
            else if (sayi == 5)
            {
                Console.WriteLine("Mayıs");
            }
            else if (sayi == 6)
            {
                Console.WriteLine("Haziran");
            }
            else if (sayi == 7)
            {
                Console.WriteLine("Temmuz");
            }
            else if (sayi == 8)
            {
                Console.WriteLine("Ağustos");
            }
            else if (sayi == 9)
            {
                Console.WriteLine("Eylül");
            }
            else if (sayi == 10)
            {
                Console.WriteLine("Ekim");
            }
            else if (sayi == 11)
            {
                Console.WriteLine("Kasım");
            }
            else if (sayi == 12)
            {
                Console.WriteLine("Aralık");
            }
            else
            {
                Console.WriteLine("Böyle bir ay yok");
            }

            Console.ReadLine();


        }
    }
}
