using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegBeadando
{
    class Pekaru
    {
        public string Nev { get; set; }
        public int Ar { get; set; }
        public bool Laktozmentes { get; set; }

        public override string ToString()
        {
            return $"{Nev} ({Ar} Ft / db)";
        }
    }
}
