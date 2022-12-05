using System;

namespace Practice3
{
    public class Event
    {
        private string _eventTitle;
        private string _description;
        private DateOnly _date;
        private TimeOnly _time;
        private string _address;

        public Event()
        {

        }
        public string tooShort()
        {
            //This shouldn't need encapsulation becasue its a type, right?
            
            //Console.WriteLine($"{GetTitle()} {GetDesc()} {GetDate()} {GetTime()} {GetAddress()}");
            string tooShortType = "";
            switch(this.GetType().ToString())
            {
                case "Practice3.Lecture" :
                    tooShortType = "Lecture";
                    break;                
                case "Practice3.Gathering" :
                    tooShortType = "Gathering";
                    break;
                case "Practice3.Reception" :
                    tooShortType = "Reception";
                    break;
                default:
                    tooShortType = "Standard Event";
                    break;
            }

            return $"{GetTitle()} {GetDate()} ({tooShortType})";
        }

        public string PrintEvent()
        {
            //Console.WriteLine($"{GetTitle()} {GetDesc()} {GetDate()} {GetTime()} {GetAddress()}");
            return $"{GetTitle()} {GetDesc()} {GetDate()} {GetTime()} {GetAddress()}";
        }

        //Getters
        public string GetTitle()
        {
            return _eventTitle;
        }
        public string GetDesc()
        {
            return _description;
        }
        public DateOnly GetDate()
        {
            return _date;
        }
        public TimeOnly GetTime()
        {
            return _time;
        }
        public string GetAddress()
        {
            return _address;
        }
        //Setters
        public void SetTitle(string title)
        {
            _eventTitle = title;
        }
        public void SetDesc(string description)
        {
            _description = description;
        }
        public void SetDate(DateOnly date)
        {
            _date = date;
        }
        public void SetTime(TimeOnly time)
        {
            _time = time;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }
    }
}
