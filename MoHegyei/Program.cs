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
            Beolvasas();
            Negyedik();
            Otodoik();
            Hatodik();
        }

        static void Beolvasas()
        {
            StreamReader beolvas = new StreamReader("hegyekMo.txt");
            beolvas.ReadLine();
            while (!beolvas.EndOfStream)
            {
                string[] adat = beolvas.ReadLine().Split(';');
                csucsok.Add(new Hegycsucs(adat[0], adat[1], int.Parse(adat[2])));
            }
            beolvas.Close();
            Console.WriteLine($"Hegycsúcsok száma: {csucsok.Count} db");
        }
        static void Negyedik()
        {
            double atlag = 0;
            double sum = 0;

            foreach (var item in csucsok)
            {
                sum = sum + item.Magassag;
            }
            atlag = sum / csucsok.Count;
            Console.WriteLine($"4. feladat: A hegyek magasságának az átlaga: {atlag}");
        }

        static void Otodoik()
        {
            string neve = "";
            string hegyseg = "";
            int magassag = 0;
            int seged = 0;

            foreach (var item in csucsok)
            {
                if (seged < item.Magassag)
                {
                    seged = item.Magassag;
                    neve = item.Hegy;
                    hegyseg = item.Hegyseg;
                    magassag = item.Magassag;
                }
            }
            Console.WriteLine($"5. feladat: A legamagasabb hegycsúcs adatai: ");
            Console.WriteLine($"Név: {neve}, Hegység: {hegyseg}, Magassága: {magassag}m.");
        }


        static void Hatodik()
        {
            Console.WriteLine("6. feladat: Kérek egy magasségot: ");
            int adat = Convert.ToInt32(Console.ReadLine());
            int megfelel = 0;

            foreach (var item in csucsok)
            {
                if (item.Hegyseg.Contains("Börzsöny"))
                {
                    if (adat < item.Magassag)
                    {
                        megfelel = item.Magassag;
                        Console.WriteLine($"Van magasabb hegycsúcs a Börzsönybeen {adat}m-nál, mégpedig a {megfelel}m magas {item.Hegy} az.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{adat}-nál nincs magasabb hegycsúcs a Börzsönyben!");
                        break;
                    }
                }
            }
        }
    }
}
