using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Operacion
    {
        public int Numero { get; set; }

        public DateTime fecha { get; set; }
        public List<Cuentas> Cuentas { get; set; }
        
        public Operacion()
        {
            Cuentas = new List<Cuentas>();
        }

        
    }
}
