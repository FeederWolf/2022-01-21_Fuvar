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
            foreach (var s in File.ReadAllLines("fuvar.csv").Skip(1))
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

            //Dictionary<int, int> stat = new Dictionary<int, int>();
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

        }
    }
}
