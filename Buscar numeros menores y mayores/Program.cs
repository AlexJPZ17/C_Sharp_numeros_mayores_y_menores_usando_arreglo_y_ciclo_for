using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscar_numeros_menores_y_mayores
{
    class Program
    {
        private static void MenorMayor()
        {
            //Declaramos las variables 
            int numero, num = 0, menor, mayor, suma;
            double promedio;
            //Mostramos un mensaje y obtenemos el dato 
            Console.WriteLine("Introduzca el número de posiciones");
            num = Convert.ToInt32(Console.ReadLine());
            //Declaramos un arreglo
            int[] arreglo = new int[num];
            //introducimos los números utilizando un ciclo for
            for (int i = 0; i < arreglo.Length; i++)
            {
                //Mostramos un mensaje y obtenemos el dato 
                Console.WriteLine("Instroduzca el número " + (i + 1));
                numero = Convert.ToInt32(Console.ReadLine());
                arreglo[i] = numero;
            }
            //Buscar el menor y mayor
            menor = arreglo[0];
            mayor = arreglo[0];
            //Ciclo for
            for (int j = 0; j <arreglo.Length; j++)
            {
                //Condiciones que evalúan las variables menor, mayor y arreglo
                if (menor > arreglo[j])
                {
                    menor = arreglo[j];
                }
                if (mayor < arreglo[j])
                {
                    mayor = arreglo[j];
                }
            }
            //Calcular promedio
            suma = 0;
            for (int x = 0; x < arreglo.Length; x++)
            {
                suma = suma + arreglo[x];
            }
            promedio = suma / arreglo.Length;
            //Mostramos los reusltados
            Console.WriteLine("El número menor es: " + menor);
            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("El promedio de los numero es: " + promedio);
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            //Mandamos a llamar al método MenorMayor
            MenorMayor();
        }
    }
}
