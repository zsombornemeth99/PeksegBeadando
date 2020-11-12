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
        public List<Pekaru> Termekek { get; }
        public DateTime Alapitva { get; }

        public override string ToString()
        {
            return $"{Nev} - {Alapitva.ToShortDateString()}";
        }
    }
}
