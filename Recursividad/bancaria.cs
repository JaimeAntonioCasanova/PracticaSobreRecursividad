using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class bancaria
    {
        public static double interesAnual(double capital, double intereses, int cantAño)
        {
            /*Nuestro caso base para este algoritmo es si la cantidad de años es igual a 0,
            de no serlo, procedemos con el calculo anual*/
            if (cantAño == 0)
            {
                return capital;
            }

            /*Cada vez que esta linea se ejecuta, reduce la cantidad de años en la funcion,
             una vez esta llega a 0, el caso base hace que la funcion vuelva a correr calculando 
            los intereses multiplicandolos con el capital, hasta llegar de nuevo a los parametros del caso inicial*/
            return interesAnual(capital, intereses, cantAño - 1) * (1 + intereses / 100);

        }

        public static void desglose(double capital, double intereses, int cantAño)
        {
            //Escribimos los valores iniciales para muestra
            Console.WriteLine($"Año 0: ${capital:F2}");

            //Iteramos cada vez que pasa un año para calcular el desglose por año
            for (int i = 1; i <= cantAño; i++)
            {
                /*Utilizamos el algoritmo recursivo para poder editar estas variables iterables,
                esto nos permite escribir una linea cada vez que se utiliza el algoritmo
                recursivo, para ser capaces de ver como cambia en detalle*/
                double capitalAnterior = interesAnual(capital, intereses, i - 1);
                double capitalActual = interesAnual(capital, intereses, i);
                double interesGanado = capitalActual - capitalAnterior;

                //El :F2 marca el formato de decimales para que no se puedan exceder de 2 digitos
                Console.WriteLine($"Año {i}: ${capitalActual:F2} (interés ganado: ${interesGanado:F2})");
            }
        }
    }
}
