using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niño_joven_adulto
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("dime tu  edad y te ddire si eres niño, adolescente, joven o adulto");
            Console.Write("que edad tienes: ");
            edad = int.Parse(Console.ReadLine());
            if ((edad >= 0) & (edad <= 10))
            {
                Console.Write("eres un niño");
            }
            else if ((edad >= 11) & (edad <= 20))
            {
                Console.Write("eres un adolescente");
            }
            else if ((edad >= 20) & (edad <= 25))
            {
                Console.Write("eres un joven");
            }
            if(edad >=26)
            {
                Console.WriteLine("eres un adulto");
            }
            Console.ReadKey();
            
        }
    }
}
