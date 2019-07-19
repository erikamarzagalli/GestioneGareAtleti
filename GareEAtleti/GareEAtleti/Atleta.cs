using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GareEAtleti
{
    class Atleta
    {
        public int id;
        public string nome;
        public string cognome;
        public int peso;
        public DateTime nascita;
        public List<Gara> Gare;
        public int posto;

        public Atleta()
        {
            Gare = new List<Gara>();
        }

        public Atleta (int id, string nome, string cognome, int peso, DateTime nascita, List<Gara> gare, int posto)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.peso = peso;
            this.nascita = nascita;
            this.Gare = new List<Gara>();
            this.posto = posto;
        }



        
    }
}
