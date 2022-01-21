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
            Console.WriteLine($"3. feladat: {taxi.Count} fucar");

        }
    }
}
