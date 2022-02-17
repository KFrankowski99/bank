using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bank
    {


        public Bank()
        {
            TworzenieKlientow();
        }



        public List<Klient> Klienci { get; set; } = new List<Klient>();





      public  void TworzenieKlientow()
        {
            Klienci.Add(new Klient(1, "Jan Nowak", "001", 1457.23m));
            Klienci.Add(new Klient(2, "Agnieszka Kowalska", "002", 3600.18m));
            Klienci.Add(new Klient(3, "Robert Lewandowski", "003", 2745.03m));
            Klienci.Add(new Klient(4, "Zofia Plucińska", "004", 7344.00m));
            Klienci.Add(new Klient(5, "Grzegorz Braun", "005", 455.38m));

        }



  







        }




    
}
