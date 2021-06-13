using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    class CSFunciones
    {
		//Suma
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

		public static void MostrarResultados(int num1, int num2, int suma, int multiplicacion)
        {
			Console.Write("El resultado de la suma de " + num1 + " + " + num2 + "es: " + suma + ".");
			Console.Write("\nEl resultado de la multiplicacion de " + num1 + " + " + num2 + "es: " + multiplicacion + ".");
		}
	}
}
