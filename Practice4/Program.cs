using System;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of activity objects.
            List<Activity> activityList = new List<Activity>();

            //create running object
            Running r1 = new Running();
            var rDate = new DateOnly(2023, 03, 17);
            r1.SetDate(rDate);
            r1.SetMinutes(90);
            r1.SetDistance(10);
            //more info here
            activityList.Add(r1);

            //Create cycling object
            Cycling c1 = new Cycling();
            var cyDate = new DateOnly(2023, 01, 01);
            c1.SetDate(cyDate);
            //string monthcode = 
            c1.SetMinutes(75);
            c1.SetSpeed(25);
            activityList.Add(c1);
            
            //Create swimming object
            Swimming s1 = new Swimming();
            var sDate = new DateOnly(2023, 12, 25);
            s1.SetDate(sDate);
            s1.SetMinutes(25);
            s1.SetLaps(20);
            //more info here
            activityList.Add(s1);

            //Loop through activities and print the summary.
            foreach (Activity a in activityList)
            {
                Console.WriteLine(a.GetSummary());
            }

        }
    }
}
