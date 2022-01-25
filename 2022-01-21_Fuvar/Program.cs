using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_01_21_Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<temitrohogsz> taxi = new List<temitrohogsz>();
            foreach (var s in File.ReadAllLines("fuvar.csv", Encoding.UTF8).Skip(1))
            {
                taxi.Add(new temitrohogsz(s));
            }
            Console.WriteLine($"3. feladat: {taxi.Count} fuvar");
            double dij = 0;
            int fuvar = 0;
            foreach (var i in taxi)
            {
                if (i.id == 6185)
                {
                    dij += i.bor;
                    fuvar++;
                }
            }
            Console.WriteLine($"4. feladat: {fuvar} fuvar alatt: {dij}$");

            int bk = 0;
            int nbk = 0;
            int f = 0;
            int idk = 0;
            foreach (var i in taxi)
            {
                if (i.fizetes_modja == "bankkártya")
                {
                    bk++;
                }
                else if (i.fizetes_modja == "készpénz")
                {
                    nbk++;
                }
                else if (i.fizetes_modja == "ingyenes")
                {
                    f++;
                }
                else if (i.fizetes_modja == "ismeretlen") {
                    idk++;
                }
            }
            Console.WriteLine("5. feladat:");
            Console.WriteLine($"\tbankkártya: {bk} fuvar");
            Console.WriteLine($"\tkészpénz: {nbk} fuvar");
            Console.WriteLine($"\tingyenes: {f} fuvar");
            Console.WriteLine($"\tismeretlen: {idk} fuvar");

            double t = 0;
            foreach (var i in taxi)
            {
                    t += i.tavolsag * 1.6;
            }
            Console.WriteLine("6. feladat: {0:0.00}km", t);

            temitrohogsz vmax = taxi[0];
            foreach (var i in taxi)
            {
                if (i.idotartalom > vmax.idotartalom)
                {
                    vmax = i;
                }
            }
            Console.WriteLine("7. feladat: Leghosszabb fuvar:");
            Console.WriteLine($"\tFuvar hossza: {vmax.idotartalom} másodperc");
            Console.WriteLine($"\tTaxi azonosító: {vmax.id}");
            Console.WriteLine($"\tMegtett távolság: {vmax.tavolsag} km");
            Console.WriteLine($"\tViteldíj: {vmax.viteldij}$");

            Console.WriteLine("8. feladat: hibak.txt");
            StreamWriter sv = File.CreateText("hibak.txt");
            foreach (var i in taxi)
            {
               if (i.idotartalom > 0 && i.viteldij > 0 && i.tavolsag == 0)
                {
                   sv.WriteLine($"{i.id};{i.indul};{i.idotartalom};{i.tavolsag};{i.viteldij};{i.bor};{i.fizetes_modja}", Encoding.UTF8);
                }
            }
        }
    }
}
