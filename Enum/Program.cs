using System;
namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = new FilTyper();
            ft = FilTyper.csv;

            Console.WriteLine(ft);
            Console.WriteLine(ft);

            Person p = new Person();

            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);


            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }



        }

    }

    public struct Person
    {
        public int Id;
        public string Navn;
        

        



    }

    public enum FilTyper
    {
        csv,
        pdf,
        txt
    }
}
