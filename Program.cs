//Programa elabanorado por Cristian Jesus Garcia Tapia
using System;

namespace Actividad1
{
class Program{

static void Main(){

 //Primer Codigo
        Console.WriteLine("Primer Codigo");

        for (int i=1; i<=100; i++){

            if (i%3==0 && i%5==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i%3==0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i%5==0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

 //Primer Codigo
        Console.WriteLine("Codigol Optimizado");
           for (int i=1; i<=100; i++){
            string output="";
            if (i%3==0) output += "Fizz";
            if (i%5==0) output += "Buzz";

            Console.WriteLine (output!="" ? output : i.ToString());


    }
} 
}
}

