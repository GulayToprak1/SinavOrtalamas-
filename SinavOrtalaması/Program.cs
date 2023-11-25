using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavOrtalaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                int exam1, exam2, exam3, ort;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sınav Not Hesaplaması");
                Console.WriteLine();

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("1.Notu Giriniz: ");

                    if (int.TryParse(Console.ReadLine(), out exam1) && exam1 >= 0 && exam1 <= 100)
                        break;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Hata! Lütfen 0 ile 100 arasında bir değer giriniz.");
                    }
                }


                Console.Clear();

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("2.Notu Giriniz: ");

                    if (int.TryParse(Console.ReadLine(), out exam2) && exam2 >= 0 && exam2 <= 100)
                        break;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Hata! Lütfen 0 ile 100 arasında bir değer giriniz.");
                    }
                }

                Console.Clear();

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("3.Notu Giriniz: ");

                    if (int.TryParse(Console.ReadLine(), out exam3) && exam3 >= 0 && exam3 <= 100)
                        break;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Hata! Lütfen 0 ile 100 arasında bir değer giriniz.");
                    }
                }

                Console.Clear();

                ort = (exam1 + exam2 + exam3) / 3;

                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (ort <= 45)
                    Console.WriteLine("Not: FF");
                else if (ort >= 45 && ort <= 65)
                    Console.WriteLine("Not: DD");
                else if (ort >= 65 && ort <= 75)
                    Console.WriteLine("Not: CC");
                else if (ort >= 75 && ort <= 85)
                    Console.WriteLine("Not: BB");
                else if (ort >= 85 && ort <= 100)
                    Console.WriteLine("Not: AA");

            }
        }
    }
}
