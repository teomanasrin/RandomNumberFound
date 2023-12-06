using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    class rastgele
    {
        private int rastgeleSayi;

        public void Random()   
        {
            int tahmin = TahminAl();
            rastgeleSayi = RastgeleSayiUret();
            while (true) 
            { 
                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine("Tebrikler! Dogru tahmin.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlis tahmin tekrar dene.");
                    tahmin = TahminAl();
                }

            }
        }
        public int RastgeleSayiUret()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }

        public int TahminAl()
        {
            int tahmin;
            Console.WriteLine("1-10 arasi sayi tahmin et");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(RastgeleSayiUret() + " <= Uretilen sayi");
            Console.ForegroundColor= ConsoleColor.White;
            tahmin = Convert.ToInt32(Console.ReadLine());
            return tahmin;
        }
        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            rastgele rastgele = new rastgele();
            rastgele.Random();
        }
    }
}
