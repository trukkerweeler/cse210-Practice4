using System;

namespace Practice2
{
    class Program
    {
        //string shippingLabel = "";
        static void Main(string[] args)
        {
            //Make a list of orders
            List<Order> orderList = new List<Order>();
            
            //Make some products
            Products cks = new Products();
            cks.SetName("crankshaft");
            cks.SetPrice(799.99);
            cks.SetId("cs001");
            cks.SetQty(1);
            
            Products p = new Products();
            p.SetName("piston");
            p.SetPrice(15.99);
            p.SetId("p0001");
            p.SetQty(1);     

            Products cr = new Products();
            cr.SetName("Connecting Rod");
            cr.SetPrice(25.99);
            cr.SetId("cr001");
            cr.SetQty(1);     

            Products soc = new Products();
            soc.SetName("Slice of Cheese");
            soc.SetPrice(0.99);
            soc.SetId("soc01");
            soc.SetQty(2);

            Products ts = new Products();
            ts.SetName("Rocker");
            ts.SetPrice(8.99);
            ts.SetId("r0001");
            ts.SetQty(1);

            Products domShip = new Products();
            domShip.SetName("Domestic Shipping Fee");
            domShip.SetPrice(5.00);
            domShip.SetId("domShip");
            domShip.SetQty(1);

            Products expShip = new Products();
            expShip.SetName("Export Shipping Fee");
            expShip.SetPrice(35.00);
            expShip.SetId("expShip");
            expShip.SetQty(1);

            //Make customer addresses
            Address jenny = new Address();
            jenny.SetAddress("1981 TuTone","Keller","CA","USA");
            Address malcolm = new Address();
            malcolm.SetAddress("1976 Dirty Deeds","Glasgow","Scotland","UK");
            
            //Make Order lines and add to order
            Order order1 = new Order();            
            order1.SetCustomerNo("Jenny");
            order1.SetOrderNo(8675309);
            order1.SetOrderAddress(jenny);

            //Add products to order products list
            order1.AddOrderLine(cks);
            order1.AddOrderLine(p);
            order1.AddOrderLine(soc);

            Order order2 = new Order();
            order2.SetCustomerNo("Malcolm");
            order2.SetOrderNo(3624350);
            order2.SetOrderAddress(malcolm);

            //Add products to order products list
            order2.AddOrderLine(ts);
            order2.AddOrderLine(p);                       

            //Add orders to the orderlist
            orderList.Add(order1);
            orderList.Add(order2);

            //Print from a list of orders
            foreach (Order order in orderList)
            {
                Address orderAddress = order.GetOrderAddress();
                if (orderAddress.Domestic() == true)
                {
                    order.AddOrderLine(domShip);
                }
                else
                {
                    order.AddOrderLine(expShip);
                }

                string thisPackingList = order.PrintPacking();
                Console.WriteLine(thisPackingList);
                Console.WriteLine();

                string thisShippingLabel = order.PrintShipping();
                Console.WriteLine(thisShippingLabel);
                Console.WriteLine("=======================================");

            }            
        }
    }
}
