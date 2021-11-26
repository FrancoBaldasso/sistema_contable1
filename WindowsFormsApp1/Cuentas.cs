using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cuentas
    {


        public int codigo { get; set; }
        public string Nombre { get; set; }

        public double Debe { get; set; }

        public double Haber { get; set; }
        public List<double> DebeLista { get; set; }
        
        public List<double> HaberLista { get; set; }

        public Cuentas(string nombre)
        {
            Nombre = nombre;
            DebeLista = new List<double>();
            HaberLista = new List<double>();
        }

        public Cuentas()
        {
            DebeLista = new List<double>();
            HaberLista = new List<double>();
        }
    }
}
