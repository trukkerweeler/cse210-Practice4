using System;

namespace Practice4
{
    public class Activity
    {
        private float _minutes;
        private DateOnly _date;

        public Activity()
        {
            _minutes = 0f;
        }
        //This is the one and only needed GetSummary. Because we used polymorphism, only 1 is needed!
        public virtual string GetSummary()
        {
            //return "Activity stats.";
            return $"{GetDate()} Cycling ({GetMinutes()} min): Distance was {GetDistance()} km, Speed {GetSpeed().ToString("0.00")} kph, Pace: {GetPace().ToString("0.0")} min per km.";

        }        
        //Methods for the base class.
        public virtual float GetDistance()
        {
            return GetMinutes() * GetSpeed() / 60.0f;
        }

        public virtual float GetSpeed()
        {
            return (GetDistance() / GetMinutes()) * 60.0f;
        }

        public virtual float GetPace()
        {
            return GetMinutes() / GetDistance();
        }

        public void SetMinutes(int minutes = 0)
        {
            _minutes = minutes;
        }

        public float GetMinutes()
        {
            return _minutes;
        }

        public void SetDate(DateOnly date)
        {
            _date = date;
        }

        //I couldn't find the method to return the 3-letter month, so I made this else I was gonna die.
        public string GetDate()
        {
            string monthText;
            switch (_date.Month)
            {
                case 01:
                {
                    monthText = "Jan";
                    break;
                }
                case 02:
                {
                    monthText = "Feb";
                    break;
                }
                case 03:
                {
                    monthText = "Mar";
                    break;
                }
                case 04:
                {
                    monthText = "Apr";
                    break;
                }
                case 05:
                {
                    monthText = "May";
                    break;
                }
                case 06:
                {
                    monthText = "Jun";
                    break;
                }
                case 07:
                {
                    monthText = "Jul";
                    break;
                }
                case 08:
                {
                    monthText = "Aug";
                    break;
                }
                case 09:
                {
                    monthText = "Sep";
                    break;
                }
                case 10:
                {
                    monthText = "Oct";
                    break;
                }
                case 11:
                {
                    monthText = "Nov";
                    break;
                }
                case 12:
                {
                    monthText = "Dec";
                    break;
                }
                default:
                {
                    monthText = "Unk";
                    break;
                }
            }
            
            return $"{_date.Day} {monthText} {_date.Year}";
        }
    }
}
