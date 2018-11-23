using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {

            int Y = 1;
            Console.WriteLine(Y);

            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string concat = fornavn + " " + efternavn;

            Console.WriteLine(concat);

            string navnStort;
            navnStort = concat;
            navnStort.ToUpper();

            Console.WriteLine(navnStort.ToUpper());

            string lilleNavn;
            lilleNavn = concat;
            
            Console.WriteLine(lilleNavn.ToLower());

            string del;
            del = efternavn.Substring(0, 4);

            Console.WriteLine(del);
            string a;
            a = "\t1\t2";
            Console.WriteLine(fornavn + "\r\n" +efternavn);

            a = @"c:\temp\fil.txt";
            Console.WriteLine(a);

            System.IO.File.WriteAllText("c:\\temp\\test.txt",concat);




            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
