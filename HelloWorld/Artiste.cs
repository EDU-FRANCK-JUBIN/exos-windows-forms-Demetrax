using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Artiste
    {
        private string _nomArtiste;
        private List<Chanson> _chansons;

        public Artiste(string nomArtiste, List<Chanson> chansons)
        {
            _nomArtiste = nomArtiste;
            _chansons = chansons;
        }

        public Artiste()
        {
        }

        public string NomArtiste
        {
            get { return _nomArtiste; }
            set { _nomArtiste = value; }
        }

        public List<Chanson> Chansons
        {
            get { return _chansons; }
            set { _chansons = value; }
        }
    }
}
