using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Timers;



namespace talanddato
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 tal;
            tal = 10;
            tal++;
            Console.WriteLine(tal);
            tal--;
            Console.WriteLine(tal);
            tal += 20;
            Console.WriteLine(tal);

            double kommatal =12.5;
            kommatal++;
            Console.WriteLine(kommatal);
            kommatal--;
            Console.WriteLine(kommatal);
            kommatal *= 2;
            Console.WriteLine(kommatal);

            DateTime dt1 = System.DateTime.Now;
            Console.WriteLine("klokken er nu "+dt1);
            dt1 = dt1.AddDays(10);
            Console.WriteLine("Dagen er nu " + dt1);
            dt1.AddMinutes(20);
            Console.WriteLine("klokken er nu " + dt1);
            dt1.AddMonths(-1);
            Console.WriteLine("Datoen er nu " + dt1);
            DateTime dt2;
            dt2 = DateTime.Now;

            TimeSpan t2;

            t2 = dt1 -dt2;
                        
            Console.WriteLine("tid mellem dat1 og dato2  " + t2 ) ;
            Console.WriteLine("dage mellem dato1 og dato2 " + t2.Days);
            TimeSpan t3 = new TimeSpan(16, 0, 0);
            Console.WriteLine("tid " + t3);

            TimeSpan t4 = new TimeSpan(00, 30, 0);
            Console.WriteLine("minuter " + t4);

            TimeSpan t5 = new TimeSpan();

            t5 = t3 - t4;
            Console.WriteLine("forskel " + t5);

            TimeSpan t6 = new TimeSpan();

            t6 = t3 + t4;
            Console.WriteLine("forskel " + t6);

            string s1  = Console.ReadLine();
            dt1 = System.Convert.ToDateTime(s1);


            dt2 = DateTime.Now;

            TimeSpan tt = dt2 - dt1;
            Console.WriteLine("forskel mellen indtastet dato og nu " + tt.Days);
            Console.WriteLine("antal timer " + tt.TotalHours);



            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }


        }
    }
}
