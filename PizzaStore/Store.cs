using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    public class Store
    {
        public Store() 
        { 
            

        }

        public void Start()
        {
            Topping top1 = new Topping("tomato", 5);
            Topping top2 = new Topping("olive", 7);
            Topping top3 = new Topping("pepperoni", 8);

            Pizza pizza1 = new Pizza("Pepperoni", 85, top1);
            Pizza pizza2 = new Pizza("Calzone", 80, top3);
            Pizza pizza3 = new Pizza("Salad", 90, top2);

            Customer customer1 = new Customer("Miki", "Musiconvej34", 43125434);
            Customer customer2 = new Customer("Frederik", "Fynbovej12", 54938577);
            Customer customer3 = new Customer("Jais", "Fotexvej64", 12532353);

            Order order1 = new Order(pizza1, customer1);
            Order order2 = new Order(pizza2, customer2);
            Order order3 = new Order(pizza3, customer3);

            Console.WriteLine(order1.ToString());
            Console.WriteLine(order2.ToString());
            Console.WriteLine(order3.ToString());
            
            

        }
       

        




        
    }
}
