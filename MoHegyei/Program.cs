using System.Linq;
using System.Collections.Generic;
using System.IO;
using MoHegyei;
using System.Linq;


namespace MoHegyei
{
    internal class Program
    {
        static List<Hegycsucs> csucsok = new List<Hegycsucs>();

        static void Main(string[] args)
        {
            Feladat2();
            Console.WriteLine("3. feladat: Hegycsúcsok száma: {0} db", csucsok.Count);
            Console.WriteLine("4. feladat: Hegycsúcsok átlagos magassága: {0:0.00} m", Feladat4());
            Console.WriteLine("5. feladat: A legmagasabb hegycsúcs adatai: ");
            Feladat5();
            Console.Write("6. feladat: Kérek egy magasságot: ");
            int Magassag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t{0}", Feladat6(Magassag));
            Console.WriteLine("7. feladat: 3000 lábnál magasabb hegycsúcsok száma: {0}", Feladat7());
            Console.WriteLine("8. feladat: Hegység statisztika");
            Feladat8();
            Console.WriteLine("9. feladat: bukk-videk.txt");
            Feladat9();
        }
    }
}
