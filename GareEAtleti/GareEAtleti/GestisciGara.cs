using System;
using System.Collections.Generic;
using System.Linq;

namespace GareEAtleti
{
    class GestisciGara
    {
        static List<Gara> gare = new List<Gara>();
        Gara g = new Gara();

        public void InsertGara()
        {
            g.id = gare.Count > 0 ? gare.Max(x => x.id) + 1 : 1;

            Console.WriteLine("Inserisci nome gara: ");
            g.nomeGara = Console.ReadLine();

            Console.WriteLine("Inserisci data: ");
            string dataString = Console.ReadLine();
            g.dataGara = DateTime.Parse(dataString);

            Console.WriteLine("Inserisci nome sport: ");
            g.sport = Console.ReadLine();

            gare.Add(g);

            Console.WriteLine(g.id + " Gara: " + g.nomeGara + " data gara: " + g.dataGara + " sport: " + g.sport);

        }

        public void ListaGara()
        {
            foreach (var gara in gare)
            {
                Console.Write(gara.id + " Gara: " + gara.nomeGara + " data: " + gara.dataGara + " sport: " + gara.sport + Environment.NewLine); // (1)
            }

        }

        public List<Gara> GetGare()
        {
            return gare;
        }

        public void InserisciAtletaInGara()
        {
            Console.WriteLine("Inserisci Id gara: ");
            int garascelta = Int32.Parse(Console.ReadLine());

            foreach (var item in gare)
            {
                if (item.id == garascelta)
                {
                    Console.WriteLine("Gara trovata");
                    Console.WriteLine("inserisci id atleta");
                    int idAtleta = Int32.Parse(Console.ReadLine());

                    foreach (var a in GestioneAtleta.atleti)
                    {
                        if (idAtleta == a.id)
                        {
                            Console.WriteLine("Atleta identificato");
                            item.atleti.Add(a);
                        }
                        else
                        {
                            Console.WriteLine("Atleta non trovato");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Gara non trovata");
                }
            }

        }

        public void AtletiGare()
        {
            Console.WriteLine("Inserisci l'ID della gara");
            int idScelto = Int32.Parse(Console.ReadLine());

            foreach (var item in gare)
            {
                if (item.id == idScelto)
                {
                    foreach (var atleta in GestioneAtleta.atleti)
                    {
                        Console.WriteLine(atleta.id + " " + atleta.nome + " " + atleta.cognome);
                    }

                    foreach (var atleta in GestioneAtleta.atleti)
                    {
                        Console.WriteLine("inserisci il posto dell'atleta " + atleta.nome + " " + atleta.cognome + " in classifica: ");
                        atleta.posto = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(atleta.id + " " + atleta.nome + " " + atleta.cognome + " " + atleta.posto + "°classificato");
                    }
                }
            }
        }

        public void GestioneGare()
        {
            Console.WriteLine("Inserisci l'ID della gara");
            int idScelto = Int32.Parse(Console.ReadLine());

            foreach (var item in gare)
            {
                if (item.id == idScelto)
                {
                    foreach (var atleticino in GestioneAtleta.atleti)
                    {
                        if (atleticino.posto != 0)
                        {
                            Console.WriteLine(atleticino.posto + " " + atleticino.nome + " " + atleticino.cognome);
                        }
                        else
                        {
                            foreach (var atleta in GestioneAtleta.atleti)
                            {
                                Console.WriteLine("inserisci il posto dell'atleta " + atleta.nome + " " + atleta.cognome + " in classifica: ");
                                atleta.posto = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(atleta.id + " " + atleta.nome + " " + atleta.cognome + " " + atleta.posto + "°classificato");
                            }
                        }
                    }
                }

            }

        }
    }
}
