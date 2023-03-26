using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCentralita
{
    internal class LLamada
    {
        public string NumOrigen { get; set; }
        public string NumDestino { get; set; }
        public int Duracion { get; set; }
        

        public virtual int CalcularTime(int edad)
        {
            int time = edad * 3;
                       
            return time;
        }


    }
}
