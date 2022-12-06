using System;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture l1 = new Lecture();
            l1.SetSpeaker("David");
            l1.SetCapacity(1984);
            l1.SetDesc("We walk through your favorite tracks.");
            l1.SetTitle("Fair Warning");
            var tempDate = new DateOnly(2023, 03, 17);
            l1.SetDate(tempDate);
            //Console.WriteLine(l1.GetDate());
            var tempTime = new TimeOnly(23, 0, 0);
            l1.SetTime(tempTime);
            //Console.WriteLine(l1.GetTime());
            l1.SetAddress("9 Diver Down Way");
            Console.WriteLine("=========================================");
            Console.WriteLine(l1.PrintEvent());
            Console.WriteLine(l1.PrintLecture());
            Console.WriteLine(l1.tooShort());


            Gathering g1 = new Gathering();
            g1.SetForecast("Romance");
            g1.SetDesc("We pretend we're teenagers.");
            g1.SetTitle("Valentino turns off his phone");
            var gDate = new DateOnly(2023, 02, 14);
            g1.SetDate(gDate);
            var gTime = new TimeOnly(22, 0, 0);
            g1.SetTime(gTime);
            g1.SetAddress("The overlook");
            Console.WriteLine("=========================================");
            Console.WriteLine(g1.PrintEvent());
            Console.WriteLine(g1.PrintGathering());
            Console.WriteLine(g1.tooShort());



            Reception r1 = new Reception();
            r1.SetRegistered(100);
            r1.SetDesc("A night to celebrate.");
            r1.SetTitle("On a Kool night.");
            r1.SetRsvp("rsvp@rnr.com");
            var rDate = new DateOnly(1981, 02, 07);
            r1.SetDate(rDate);
            var rTime = new TimeOnly(12, 0, 0);
            r1.SetTime(rTime);
            r1.SetAddress("Jersey City");
            Console.WriteLine("=========================================");
            Console.WriteLine(r1.PrintEvent());
            Console.WriteLine(r1.PrintReception());
            Console.WriteLine(r1.tooShort());
        }
    }
}