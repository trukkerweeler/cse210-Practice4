using System;

namespace Practice2
{
    class Customer
    {
        private string _custName;
        private string _custCountry;
        
    
    public void SetCountry(string country)
    {
        _custCountry = country;
    }
    public bool Domestic()
        {
            if (_custCountry == "USA")
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
