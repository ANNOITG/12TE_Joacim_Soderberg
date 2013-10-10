using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5]; //<-- Vektorn skapas

            for (int i = 0; i < namn.Length; i++)
            {
                namn[i] = Console.ReadLine();
            }//<-- slut på loopen

            while(true)
            {
            for (int i = 0; i < namn.Length; i++) //<-- Loop för att skriva ut alla namnen
            {
                Console.WriteLine(namn[i]);//<-- Namnen skrivs ut 
            }//<-- slut på loopen

            Console.WriteLine("Mata in önskad index som du vill ändra 0-4 eller stäng ner med q och sedan Enter");
            string userInput = Console.ReadLine(); 
            if ((userInput == "q") || (userInput == "Q" ))
            {
                Environment.Exit(0);
            }
            else
            {
                int index = int.Parse(Console.ReadLine());
                namn[index] = Console.ReadLine();
            }
        }


            Console.ReadKey();

        }
    }
}
