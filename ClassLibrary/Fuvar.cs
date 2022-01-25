using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLibrary
{
    public class Fuvar
    {
        public int id { get; set; }
        public DateTime indul { get; set; }
        public int idotartalom { get; set; }
        public double tavolsag { get; set; }
        public double viteldij { get; set; }
        public double bor { get; set; }
        public string fizetes_modja { get; set; }

        public Fuvar(string sor)
        {
            string[] s = sor.Split(';');

            id = int.Parse(s[0]);
            indul = DateTime.Parse(s[1]);
            idotartalom = int.Parse(s[2]);
            tavolsag = double.Parse(s[3]);
            viteldij = double.Parse(s[4]);
            bor = double.Parse(s[5]);
            fizetes_modja = s[6];
        }

    }
}
