using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3__Tala_till_mig_
{
    class Program
    {
        static void Main(string[] args)
        {

            int i1, i2;

            while (true)
            {
                try
                {

                    string inm1 = Console.ReadLine();
                    i1 = int.Parse(inm1);
                }
                catch
                {
                    Console.WriteLine("Endast heltal får användas");
                }
            }

            while (true)
            {
                try
                {
                    string inm2 = Console.ReadLine();
                    i2 = int.Parse(inm2);
                }
                catch
                {
                    Console.WriteLine("Endast heltal får användas");
                }
            }

            int i3 = i1 + i2; //Adderar de första två inmatningarna.

            Console.WriteLine("Addition:" + i3); //Skriver ut "addition:" och svaret från aditionen (i3).

            Console.WriteLine("Inmata önskad siffra för att subtrahera talet " + i3 +"."); //Skriver ut den röda texten och svaret från additionen.

            string inm3 = Console.ReadLine(); //Skapar inm3

            int i4; //Skapar int i4

            i4 = int.Parse(inm3); //Sätter i4 lika med inm3 stringen

            int i5 = i3 - i4; //Skapar i5 vilket är lika med i3 subtraherat med i4

            Console.WriteLine("Subtraktion:" + i5); //Skriver ut "Subtraktion:" och svaret utav subtraktionen (i5).

            Console.WriteLine("Inmata önskad siffra för att multiplicera talet " + i5 +".");

            string inm4 = Console.ReadLine(); 

            int i6;

            i6 = int.Parse(inm4);

            int i7 = i5 * i6;

            Console.WriteLine("Multiplikation:" + i7);

            Console.WriteLine("Inmata önskad siffra för att dividera talet " + i7 + ".");

            string inm5 = Console.ReadLine(); 

            int i8;

            i8 = int.Parse(inm5);

            double d1 = i7 / (double)i8;

            Console.WriteLine("Division:" + d1);
            
            Console.ReadKey();
        }
    }
}
