using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    class CSFunciones
    {
        public static int Resta(int operador1, int operador2)
        {
            int resultado = operador1 - operador2;
            return (resultado);
        }
        public static int Division(int operador1, int operador2)
        {
            int resultado = operador1 / operador2;
            return (resultado);
        }
        public static void MostrarResultados(int operador1, int operador2, int result_resta,int result_div)
        {
            Console.WriteLine("Los resutados de la resta y división de " + operador1 + " y " + operador2 + " son: ");
            Console.WriteLine("Resta: " + result_resta);
            Console.WriteLine("División: " + result_div);
        }
    }
}
