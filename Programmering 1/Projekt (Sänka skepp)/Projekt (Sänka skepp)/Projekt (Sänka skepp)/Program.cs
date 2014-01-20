using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt__Sänka_skepp_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Jockes version utav sänka skepp!"
                                + "\nI denna simpla version utav sänka skepp så får du först skriva in en x kordinat och en y kordinat"
                                + "för att förhoppningsvis träffa en utav de gömda båtarna. "
                                + "\nSpelplanen har en yta på 9x9 rutor vilket betyder att det maximala värdet \nsom får skrivas in i x eller y kordinaten är 9. "
                                + "\nTryck på valfri tangent för att börja spela");
            string[,] spelplan = new string[9,9];

            spelplan[1, 2] = "*";
            spelplan[1, 3] = "*";
            spelplan[1, 4] = "*";
            
            Console.ReadKey();
        }
    }
}
