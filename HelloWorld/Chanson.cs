using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Chanson
    {
        private string _titreChanson;

        public Chanson(string titreChanson)
        {
            this._titreChanson = titreChanson;
        }

        public string TitreChanson
        {
            get { return _titreChanson; }
            set { _titreChanson = value; }
        }
    }
}
