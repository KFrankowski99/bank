using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           Bank bank = new Bank();

            int ZalogowanyKlient;
            

            while (true)
            {
                Console.WriteLine("Witamy w systemie bankowym \n Wybierz opcje co chcesz wykonac \n 1-Lista klientow \n 2-Logowanie \n 3-Zakoncz");


                var OpcjaMenu = Console.ReadLine();

                if (OpcjaMenu == "1")
                {
                    WyswietlanieKlientow();

                }
                else if (OpcjaMenu == "2")
                {
                    Logowanie();
                }
                else if (OpcjaMenu == "3")
                {
                    break;
                }

            }





            void Logowanie()
            {
                Console.WriteLine("Podaj ID zeby sie zalogowac");
                var a = Console.ReadLine();
                int PobraneId = int.Parse(a);

                if (PobraneId <= bank.Klienci.Count && PobraneId > 0)
                {
                    foreach (var c in bank.Klienci)
                    {
                        if (PobraneId == c.Id)
                        {
                            Console.Clear();
                            Console.WriteLine("Udalo sie zalogowac" );

                            Console.WriteLine("\n Id: "+c.Id + " \n Imie i Nazwisko: " + c.ImieNazwisko + " \n Nr konta: " + c.NrKonta + " \n Saldo: " + c.Saldo + " \n ");
                            Console.WriteLine("Podaj numer konta do przelewu");
                            ZalogowanyKlient = c.Id - 1;
                          var  PodanyNumerKonta=Console.ReadLine();
                            Przelew(PodanyNumerKonta);
                           



                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Zly login");
                   
                }
              }
    




            void Przelew(string PodanyNumerKonta)
            {
                var licznik=1;

            for(int i=0;i<bank.Klienci.Count+1;i++)
                {
                    if(PodanyNumerKonta == bank.Klienci[i].NrKonta)
                    {
                        
                        Console.WriteLine("Podaj kwote do Przelewu");
                        var IdDrugiegoKonta = bank.Klienci[i].Id-1;
                        var Kwota1 = Console.ReadLine();
                        decimal Kwota2 = decimal.Parse(Kwota1);
                        PrzelewNaInneKonto(Kwota2, IdDrugiegoKonta);
                        break;

                    }
                    else
                    {
                        licznik++;
                        if (licznik > 5)
                        {
                            Console.WriteLine("zle konto");
                            Console.ReadLine();
                            break;
                        }
                    }
                    



                }
                
              
            }


            void PrzelewNaInneKonto(decimal Kwota, int IdDrugiegoKonta)
            {
                   
               bank.Klienci[ZalogowanyKlient].Saldo= bank.Klienci[ZalogowanyKlient].Saldo - Kwota;
                if (bank.Klienci[ZalogowanyKlient].Saldo < 0 || bank.Klienci[ZalogowanyKlient].NrKonta == bank.Klienci[IdDrugiegoKonta].NrKonta)
                {
                    Console.WriteLine("Nie mozna wykonac przlewu");
                }
                else
                {
                    bank.Klienci[IdDrugiegoKonta].Saldo = bank.Klienci[IdDrugiegoKonta].Saldo + Kwota;
                    Console.WriteLine("Po przelewie");
                    foreach (var c in bank.Klienci)
                    {

                        Console.WriteLine(c.Id + " | " + c.ImieNazwisko + " | " + c.NrKonta + " | " + c.Saldo + " \n ");
                    }

                }
                
            }



                void WyswietlanieKlientow()
            {
                Console.WriteLine("ID | Imie i Nazwisko | Numer konta bankowego | Saldo na koncie");
                foreach (var c in bank.Klienci)
                {

                    Console.WriteLine(c.Id + " | " + c.ImieNazwisko + " | " + c.NrKonta + " | " + c.Saldo + " \n ");
                }

            }



        }
    }
}
