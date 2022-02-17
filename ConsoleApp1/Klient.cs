using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Klient
    {

        public Klient(int id, string imienazwisko, string nrkonta, decimal saldo)
        {
            Id = id;
            ImieNazwisko = imienazwisko;
            NrKonta = nrkonta;
            Saldo = saldo;
        }

        public int Id { get; set; }
        public string ImieNazwisko{ get; set; }
        public string NrKonta { get; set; }
        public decimal Saldo { get; set; }



    }
}
