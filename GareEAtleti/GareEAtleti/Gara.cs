using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GareEAtleti
{
    class Gara
    {
        public int id;
        public string nomeGara;
        public DateTime dataGara;
        public string sport;
        public List<Atleta> atleti; 

        public Gara()
        {
            atleti = new List<Atleta>();
        }

        public Gara(int id, string nomeGara, DateTime dataGara, string sport, List<Atleta> atleti)
        {
            this.id = id;
            this.nomeGara = nomeGara;
            this.dataGara = dataGara;
            this.sport = sport;
            this.atleti = atleti;
        }

    }
}
