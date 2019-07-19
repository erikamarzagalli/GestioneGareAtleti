using System;
using System.Collections.Generic;

namespace GareEAtleti
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Atleta a = new Atleta(1,"erika","marza",48,Convert.ToDateTime("2019-05-15"));
            Atleta b = new Atleta(2, "andrea", "cortesi", 70, Convert.ToDateTime("2019-03-14"));
            Atleta c = new Atleta(3, "marco", "iudica", 65, Convert.ToDateTime("2001-06-02"));
            List<Atleta> atleti = new List<Atleta> { a, b, c };*/

            Console.WriteLine("Vuoi iniziare? si/no");
            while (Console.ReadLine() == "si")
            {
                Console.WriteLine("Scegli:");
                Console.WriteLine("1- Inserisci un nuovo atleta");
                Console.WriteLine("2- Lista degli atleti");
                Console.WriteLine("3- Elimina un atleta");
                Console.WriteLine("4- Inserisci gara");
                Console.WriteLine("5- Lista gare");
                Console.WriteLine("6- Iscrivi atleta");
                Console.WriteLine("7- Lista degli atleti nelle gare");
                Console.WriteLine("8- Gestione gare");
                Console.WriteLine("9- Salva");
                Console.WriteLine("10- Esci");
                int scelta = int.Parse(Console.ReadLine());
                GestioneAtleta atleta = new GestioneAtleta();
                GestisciGara gara = new GestisciGara();
                Console.Clear();
                
                switch (scelta)
                {
                    case 1:
                        atleta.InsertAtleta();
                        Console.WriteLine("Vuoi continuare? si/no");
                        break;
                    case 2:
                        atleta.ListaAtleti();
                        Console.WriteLine("Vuoi continuare? si/no");
                        break;
                    case 3:
                        atleta.EliminaAtleta();
                        Console.WriteLine("Vuoi continuare? si/no");
                        break;
                    case 4:
                        gara.InsertGara();
                        Console.WriteLine("Vuoi continuare? si/no");
                        break;
                    case 5:
                        gara.ListaGara();
                        Console.WriteLine("Vuoi continuare? si/no");
                        break;
                    case 6:
                        gara.InserisciAtletaInGara();
                        Console.WriteLine("Vuoi continuare? si/no");
                        break;
                    case 7:
                        gara.AtletiGare();
                        Console.WriteLine("Vuoi continuare? si/no");
                        break;
                    case 8:
                        gara.GestioneGare();
                        Console.WriteLine("Vuoi continuare? si/no");
                        break;
                    case 9:
                        Console.WriteLine("Vuoi continuare? si/no");
                        break;
                    case 10:
                        Console.WriteLine("Press any key to exit.");
                        break;

                }
            }





        }
    }

}
