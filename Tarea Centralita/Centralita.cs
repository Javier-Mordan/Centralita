using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCentralita
{
    internal class Centralita: LLamada
    {
        public LLamada llamadas { get; set; }
        public Centralita()
        {            
        }
        List<LLamada> Registro = new List<LLamada>();
        public void Agregar (LLamada llamada)
        {
            llamadas = llamada;           
            Registro.Add(llamada);
        }
        
        public void Mostrar()
        {             
            foreach (var LLamada in Registro)
            {
                Console.WriteLine($"Llamada desde: {LLamada.NumOrigen} \n Duracion: {LLamada.Duracion} segundos \n Recivido desde: {LLamada.NumDestino}");

            }

        }
    }
}

