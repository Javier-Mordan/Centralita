using System;
using TareaCentralita;

namespace Centalita
{
    public class Problem
    {
        public static void Main(string[] args) 
        {            
            Console.WriteLine($" Elija que tipo de llamada desea realizar: \n 1.Local \n 2.Provincial");
            int ele = Convert.ToInt32(Console.ReadLine());
            Centralita centralita = new Centralita();

            while ( ele != 0 ) 
            {
               
                if (ele == 1)
                {
                    LlamadaLocal llamada = new LlamadaLocal(" 849 ", " 829 ");
                    Console.WriteLine($" Tiempo de llamada:{llamada.calcularTime(8)} segundos ");
                    Console.WriteLine($" Precio de la llamada: {llamada.calcularPrecio(llamada.calcularTime(8))} pesos ");
                    llamada.Duracion = llamada.calcularTime(8);
                    centralita.Agregar(llamada);
                }

                if (ele == 2)
                {
                    Console.WriteLine($" Elija la franja horaria de su llamada. \n 1) Franja 1 \n 2) Franja 2 \n 3) Franja 3 ");
                    int franja = Convert.ToInt32(Console.ReadLine());
                    LlamadaRegional llamada = new LlamadaRegional(" 809 ", " 829 ");
                    llamada.Duracion = llamada.calcularTime(8);
                    Console.WriteLine($" El precio de su llamada para la franja seleccionada es de {llamada.CalcularPrecio(llamada.calcularTime(8), franja)} pesos ");
                    centralita.Agregar(llamada);
                }


                Console.WriteLine($" Desea realizar otra llamada: \n 1) Local \n 2) Provincial \n 0) Salir ");
                ele = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine($" Si desea ver su registro de llamadas pulse 3. Si desea terminar su proceso pulse 'Enter' ");
            ele = Convert.ToInt32(Console.ReadLine());
            if (ele == 3)
            {
                centralita.Mostrar();
            }

        }
    }
}