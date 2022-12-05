using System;

namespace Practice3
{
    public class Reception : Event
    {
        private int _registered;
        private string _rsvpEmail;

        public Reception()
        {

        }

        public string PrintReception()
        {
            //Console.WriteLine($"{GetTitle()} {GetDesc()} {GetDate()} {GetTime()} {GetAddress()}");
            return $"{GetTitle()} {GetDesc()} {GetDate()} {GetTime()} {GetAddress()} {GetRsvp()}";
        }

        //Getters
        public int GetRegistered()
        {
            return _registered;
        }
        public string GetRsvp()
        {            
            return _rsvpEmail;
        }

        //Setters
        public void SetRegistered(int registered)
        {            
            _registered = _registered + registered;
        }
        public void SetRsvp(string rsvp)
        {            
            _rsvpEmail = rsvp;
        }
    }
}
