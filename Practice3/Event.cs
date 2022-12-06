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
        private string _myType;

        public Event()
        {

        }
        public string GetMyType()
        {
            switch(this.GetType().ToString())
            {
                case "Practice3.Lecture" :
                    _myType = "Lecture";
                    break;                
                case "Practice3.Gathering" :
                    _myType = "Gathering";
                    break;
                case "Practice3.Reception" :
                    _myType = "Reception";
                    break;
                default:
                    _myType = "Standard Event";
                    break;
            }

            return _myType;
        }

        public string tooShort()
        {
            return $"{GetTitle()} {GetDate()} ({GetMyType()})";
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
