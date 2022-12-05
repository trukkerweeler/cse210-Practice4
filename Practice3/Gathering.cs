using System;

namespace Practice3
{
    public class Gathering : Event
    {
        private string _forecast;

        public Gathering()
        {

        }
        public string PrintGathering()
        {
            //Console.WriteLine($"{GetTitle()} {GetDesc()} {GetDate()} {GetTime()} {GetAddress()} {GetForecast()}");
            return $"{GetTitle()} {GetDesc()} {GetDate()} {GetTime()} {GetAddress()} {GetForecast()}";
        }

        //Getters
        public string GetForecast()
        {
            return _forecast;
        }

        //Setters
        public void SetForecast(string forecast)
        {            
            _forecast = forecast;
        }
    }
}
