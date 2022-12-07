using System;

namespace Practice4
{
    public class Swimming : Activity
    {
        private float _lapCount;
        private float _meterslap;
        
        //Comments go here   
        public Swimming()
        {
            _meterslap = 50.00f;

        }

        public override float GetDistance()
        {
            return (GetLaps() * _meterslap) / 1000;
        }

        public override float GetSpeed()
        {
            
            return (GetDistance() / GetMinutes()) *60;
        }

        public void SetLaps(float laps)
        {
            _lapCount = laps;
        }
        public float GetLaps()
        {
            return _lapCount;
        }
    }
}