using System;

namespace desafio02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            Console.WriteLine("ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese cGrados: ");
            double cGrados = double.Parse(Console.ReadLine());

            //Proceso
            double c = cGrados * (Math.PI / 180.0);

            double t = (z / (Math.Sin(c)));

            Console.WriteLine("t: " + t);

            double y = Math.Sqrt(((t) * (t)) - ((z) * (z)));
            Console.WriteLine("y: " + y);

            double a = 180 - 90 - cGrados;
            Console.WriteLine("a: " + a);
        }
    }
}
