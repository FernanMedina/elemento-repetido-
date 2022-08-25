using System;
/*
Dada una lista de 10 números, cargarlos en un vector. Luego detectar si en el
vector hay algún elemento repetido. De haberlo, indicarlo con un cartel
aclaratorio “Hay repetidos”, de lo contrario indicar “No hay repetidos”.
Pista: usar ciclos combinados.
*/
namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            int numero;

            for (int x = 0; x < 5; x++)
            {
                System.Console.WriteLine($"ingrese un numero para la posicion {x + 1}");
                numero = int.Parse(Console.ReadLine());
                vector[x] = numero;
            }
            int contador = 0, resul;
            bool repetido = false;

            Console.WriteLine("El vector tiene los siguientes valores: ");
            for (int x = 0; x < 5; x++)
            {
                resul = vector[x];
                Console.WriteLine($"En la posicion {x + 1} el valor es: {vector[x]}");
                for (int i = 0; i < 5; i++)
                {
                    if (resul == vector[x])
                        contador++;
                }

                if (contador >= 2)
                    repetido = true;
            }

            if (repetido == true)
                Console.WriteLine("Hay elementos repetidos");
            else
                Console.WriteLine("No hay elementos repetidos");
        }
    }
}
