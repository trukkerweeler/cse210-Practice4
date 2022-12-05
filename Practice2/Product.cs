//Tim, you are making objects!

namespace Practice2
{
    public class Products
    {
        private string _name = "";
        private string _id = "";
        private int _qty;
        private double _price = 0.00; 

        public Products()
        {

        }
        
        public string GetProductDetail()
        {
            return $"{_id} {_name} {_price} {_qty}";
        }

        public void SetId(string id)
        {
            _id = id;
        }

        public string GetId()
        {
            return _id;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public double GetPrice()
        {
            return _price;
        }
        public void SetQty(int qty)
        {
            _qty = qty;
        }

        public double GetQty()
        {
            return _qty;
        }
    }
}