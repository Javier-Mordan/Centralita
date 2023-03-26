using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCentralita
{
    internal class LlamadaLocal: LLamada
    {
        public LlamadaLocal(string NumeroOri, string NumeroDest)
        {
            NumDestino = NumeroDest;
            NumOrigen = NumeroOri;
        }

        public int calcularTime(int edad)
        {
            int tiempo = edad * 3;
            return tiempo;
        }

        public int calcularPrecio(int tiempo)
        {
            int precio = tiempo * 15;
            return precio;
        }
    }
}
