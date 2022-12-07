using System;

namespace Practice4
{
    public class Running : Activity
    {
        private int _distance;

        //Comments go here
        public Running()
        {

        }
        //Comments go here
        public override float GetSpeed()
        {
            return (GetDistance() / GetMinutes()) * 60f;
        }
        //leaving this here for learning purposes.
        /*public override string GetSummary()
        {
            return $"{GetDate()} Running ({GetMinutes()} min): Distance was {GetDistance()} km, Speed was {GetSpeed().ToString("0.00")} kph, Pace {GetPace()} mins per km.";           
        }*/

        public void SetDistance(int km)
        {
            _distance = km;
        }
        public override float GetDistance()
        {
            return _distance;
        }


    }
}
