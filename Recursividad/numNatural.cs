using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class numNatural
    {
        public static int sumaRecursiva(int numOriginal)
        {
            /*El caso base para la recursividad en este caso
            calcula si el numero introducido es menor a 10*/

            if (numOriginal < 10) 
            {
                return numOriginal;
            }
            /*en el caso de no serlo, se toma su digito mas cercano
            a la derecha para sumarlo con el proximo de la izquierda*/

            return (numOriginal % 10) + sumaRecursiva(numOriginal/10);

        }
    }
}
