using System;

namespace Name
{
    class Program {
        static void Main(string[] args) {
            float value1;
            float value2;
            float result;

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");

            value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            value2 = float.Parse(Console.ReadLine()); 


            Console.WriteLine("");

            result = value1 + value2;
            Console.WriteLine($"O resultado da soma é: {result}");
        }
    }    
}