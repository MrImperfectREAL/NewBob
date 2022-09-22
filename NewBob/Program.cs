using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace NewBob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fjerne alt fra siste b-en i bob og til venstre
            //søk i kortere string for gang counter++
            //stringen må bli lik ny string
            //hvilke metoder?

            //oppgave 1
            //kjør programmet for å se om alt er ok

            //oppgave 2
            //Let etter gunnar og ikke bob. hva skjer? må noe endres?
            //
            //Oppgave 3
            //ikke let etter gunnar mer. endre tilbake til bob.
            //stringen bob skal leses inn fra en fil https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
            //lag en stooor textfil. tar det lang tid? lag en enda større fil. test på nytt. fortsett. hvor stor fil kan vi ha?

            //oppgave 4
            //ta tiden på dette. Bruk datetime og datediff https://www.tutorialsteacher.com/articles/get-difference-between-two-dates-in-csharp

            //oppgave 5
            //istedfor å ha alt i main, lag en metode av dette. Hva det letes etter og i hvor det letes skal være parametre. Returtype int

            //oppgave 6
            //lag en metode som heter KlassiskBob. Det er denne bobløsningen som bruker for loops
            //ta tiden på denne og avansert bob. hvem er raskest? her er det viktig at det er samme inputfil som brukes.

            ModernBob();
            TrueKlassiskBob();
        }
        static void FinnGunnar()
        {
            //1+2

            int counter = 0;
            string bob = "aaagunnarpergunnar"; //lese inn fra fil
            string newBob = "";
            int hvor = 0;
            while (bob.Contains("gunnar"))
                if (bob.Contains("gunnar"))
                {
                    hvor = bob.IndexOf("gunnar");
                    newBob = bob.Substring(hvor + 6, bob.Length - hvor - 6);//overwrite bob
                    bob = newBob;
                    counter++;
                }
            Console.WriteLine(counter);
            Console.ReadLine();
        }

        static void SemiKlassiskBob()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int counter = 0;
            string bob = System.IO.File.ReadAllText(@"C:\Users\brend\Desktop\WriteText.txt"); //lese inn fra fil
            int hvor = 0;
            while (bob.Contains("bob"))
                {
                    hvor = bob.IndexOf("bob");
                    bob = bob.Substring(hvor + 3, bob.Length - hvor - 3);//overwrite bob
                    counter++;
                }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(counter);
            Console.ReadLine();
        }

        static void ModernBob()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string x = File.ReadAllText(@"C:\Users\brend\Desktop\WriteText.txt");
            char[] zs = { 'b', 'o', 'b' };
            var z = x.Split(zs);
            int c = 0;
            Console.WriteLine((z.Length - 1) / 3);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void TrueKlassiskBob()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int counter = 0;
            string bob = System.IO.File.ReadAllText(@"C:\Users\brend\Desktop\WriteText.txt"); //lese inn fra fil
            char[] bobarray = bob.ToCharArray();
            for(int i = 0; i < bobarray.Length-2; i++)
            {
                if (bobarray[i] == 'b' && bobarray[i + 1] == 'o' && bobarray[i + 2] == 'b')
                {
                    i = i + 2;
                    counter++;
                }
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.Write(counter);
            Console.ReadLine();
        }
    }
}
