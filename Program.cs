using System;

namespace ConsoleAppEjercicio1DeEnzoMarmol
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, velocidad, tiempo, metros, segundos, distanciaenkm;

            Console.WriteLine("ingrese los metros para la velocidad: ");
            metros = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese los segundos para la velocidad: ");
            segundos = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el lapso de tiempo: ");
            tiempo = double.Parse(Console.ReadLine());

            velocidad = metros / segundos;

            Console.WriteLine($"el vehiculo esta yendo a {velocidad} m/s");

            distancia = velocidad * tiempo;

            Console.WriteLine($"la distancia recorrida es {distancia} metros");

            distanciaenkm = distancia / 1000;
            Console.WriteLine($"la distancia en kilometros es {distanciaenkm} km");
            Console.ReadLine();


        }
    }
}
