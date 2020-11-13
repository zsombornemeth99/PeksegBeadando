using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegBeadando
{
    class Pekseg
    {
        public string Nev { get; set; }
        public List<Pekaru> Termekek { get; set; }
        public DateTime Alapitva { get; set; }

        public override string ToString()
        {
            return $"{Nev} - {Alapitva.ToShortDateString()}";
        }
    }
}
