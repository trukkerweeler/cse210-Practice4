
namespace Practice2
{
    public class Order
    {
        //private List<OrderItems> _orderItems;
        private int _orderNo;
        private string _customerName;
        public List<Products> _product = new List<Products>();
        private Address _orderAddress;

        public Order()
        {

        }        

        internal void SetOrderAddress(Address orderAddress)
        {
            _orderAddress = orderAddress;
        }

        internal Address GetOrderAddress()
        {
            return _orderAddress;
        }

        public string PrintPacking()
        {
            double total = 0.00;
            string packingString = "-----------Packing List-----------" + Environment.NewLine;
            packingString += $"{this._customerName} / Order No: {this._orderNo}" + Environment.NewLine;
            foreach (Products product in this._product)
            {
                double price = product.GetPrice();
                double qty = product.GetQty();
                string id = product.GetId();
                string name = product.GetName();
                double extended = price * qty;
                total = total + extended;
                //Console.WriteLine($"({qty}) {product.GetName()} ${extended.ToString()}");
                packingString += $"({qty}) {id}: {name} ${extended.ToString()}" + Environment.NewLine;
            }
            packingString += $"Total: ${total.ToString("0.00")}";
            return packingString;          
        }

        public string PrintShipping()
        {
            //string innerAddress;
            string shippingString = "-----------Address Label-----------" + Environment.NewLine;
            shippingString += $"{this._customerName}" + Environment.NewLine;
            shippingString += _orderAddress.getFormattedAddress() + Environment.NewLine;

            return shippingString;
        }

        public void SetOrderNo(int orderNo)
        {
            _orderNo = orderNo;
        }
        public void SetCustomerNo(string customerName)
        {
            _customerName = customerName;
        }
        public void AddOrderLine(Products product)
        {
            _product.Add(product);
        }
        public List<Products> GetProduct()
        {
            return _product;
        }
    }
}
