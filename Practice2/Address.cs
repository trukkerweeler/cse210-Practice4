using System;

namespace Practice2
{
    class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        internal Address()
        {
            
        }

        public string GetCountry()
        {
            return _country;
        }

        public string getFormattedAddress()
        {
            string innerAddress = "";
            innerAddress += $"{_street}" + Environment.NewLine;
            innerAddress += $"{_city}, ";
            innerAddress += $"{_state}, ";
            innerAddress += $"{_country}";
            return innerAddress;
        }
        
        public void SetAddress(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        public bool Domestic()
        {
            if (_country == "USA")
            {
                //Console.WriteLine("Address is domestic.");
                return true;
            }
            else
            {
                //Console.WriteLine("Address is foreign!");
                return false;
            }
        }
        
    }
}
