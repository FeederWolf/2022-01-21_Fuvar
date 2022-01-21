using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_21_Fuvar
{
    class temitrohogsz
    {
        public int id { get; set; }
        public DateTime indul { get; set; }
        public int idotartalom { get; set; }
        public double tavolsag { get; set; }
        public double viteldij { get; set; }
        public double bor { get; set; }
        public string bankkartya { get; set; }

        public temitrohogsz(string sor) {
            string[] s = sor.Split(';');
            id = int.Parse(s[0]);
            indul = DateTime.Parse(s[1]);
            tavolsag = double.Parse(s[2]);
            viteldij = double.Parse(s[3]);
            bor = double.Parse(s[4]);
            bankkartya = s[5];

        }

    }
}
