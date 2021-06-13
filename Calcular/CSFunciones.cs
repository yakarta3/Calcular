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
            public static int Suma(int num1, int num2)
            {
                int suma = num1 + num2;
                return (suma);
            }

            //Multiplicacion
            public static int Multiplicacion(int num1, int num2)
            {
                int multiplica = num1 + num2;
                return (multiplica);
            }
            public static void MostrarResultados(int operador1, int operador2, int suma, int result_resta, int multiplicacion, int result_div)
            {
                Console.Write("El resultado de la suma de " + operador1 + " + " + operador2 + "es: " + suma + ".");
                Console.Write("\nEl resultado de la multiplicacion de " + operador1 + " + " + operador2 + "es: " + multiplicacion + ".");
                Console.WriteLine("Los resutados de la resta y división de " + operador1 + " y " + operador2 + " son: ");
                Console.WriteLine("Resta: " + result_resta);
                Console.WriteLine("División: " + result_div);

            }

        }
}
