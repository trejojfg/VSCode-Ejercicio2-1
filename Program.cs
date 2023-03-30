using System;

namespace Ejercicio2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
            
            int n1, n2, R;
            Console.WriteLine("Introducir 1º Número");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir 2º Número");
            n2 = int.Parse(Console.ReadLine());
            R = n1 + n2;
            Console.WriteLine("El Resultado es " + R);

        }
    }
}
