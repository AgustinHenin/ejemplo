using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Marca
    {
        public string nombre { get; set; }
        public string rubro { get; set; }
        public string origen { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
