using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GareEAtleti
{
    class GestioneAtleta
    {
        public static List<Atleta> atleti = new List<Atleta>();

        Atleta a = new Atleta();

        Gara g = new Gara();

        public void InsertAtleta()
        {

            a.id = atleti.Count > 0 ? atleti.Max(x => x.id) + 1 : 1;

            Console.WriteLine("Inserisci nome: ");
            a.nome = Console.ReadLine();

            Console.WriteLine("Inserisci Cognome: ");
            a.cognome = Console.ReadLine();

            Console.WriteLine("Inserisci il peso: ");
            string pesoString = Console.ReadLine();
            a.peso = Byte.Parse(pesoString);

            Console.WriteLine("Inserisci data di nascita: ");
            string nascitaString = Console.ReadLine();
            a.nascita = DateTime.Parse(nascitaString);

            atleti.Add(a);

            Console.WriteLine(a.id + " Atleta: " + a.nome + " " + a.cognome + " peso: " + a.peso + " nato il: " + a.nascita);
        }

        public void ListaAtleti()
        {
            foreach (var atleta in atleti)
            {
                Console.Write(atleta.id + " nome: " + atleta.nome + " " + atleta.cognome + " peso: " + atleta.peso + " data di nascita: " + atleta.nascita + Environment.NewLine); // (1)
            }

        }

        public void EliminaAtleta()
        {
            Console.WriteLine("Scegli atleta scrivendo id: ");
            int idScelto = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < atleti.Count; i++)
            {
                if (atleti[i].id == idScelto)
                {
                    atleti.Remove(atleti[i]);
                    Console.WriteLine("Atleta rimosso con successo!");
                }
            }
        }

        public void IscriviAtleta(List<Gara> listaGare)
        {
            Console.WriteLine("Scegli atleta scrivendo id: ");
            a.id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Scegli id gara a cui vuoi iscrivere " + a.nome + " " + a.cognome);
            g.id = Int32.Parse(Console.ReadLine());

            var atletaDaiscrivere = atleti.Find(x => x.id == a.id);

            Gara gara = null;

            foreach (var item in listaGare)
            {
                if (g.id == item.id)
                {                    
                    item.atleti.Add(atletaDaiscrivere);
                    gara = item;
                }
            }

            atleti.Find(x => x.id == a.id).Gare.Add(gara);
            Console.Write(atletaDaiscrivere.id + " nome: " + atletaDaiscrivere.nome + " " + atletaDaiscrivere.cognome + " iscritto a gara: " + gara.id + " " + gara.nomeGara);

        }

    }

}

