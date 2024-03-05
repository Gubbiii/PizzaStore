using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Order
    {
        Pizza _pizza;
        Customer _customer;
        int deliveryCost = 40; //lokal variabel
        double tax = 1.25;

        public Order(Pizza pizza, Customer customer)
        {
            _pizza = pizza;
            _customer = customer;
            
        }
        public Pizza pizza
        {
            get { return _pizza; }
            private set { _pizza = value; }
        }
        public Customer customer
        {
            get { return _customer; }
            private set { _customer = value; }
        }

        

        public double CalculateTotalPrice()
        {
           Double totalPrice = (_pizza.Price + deliveryCost) * tax;
            return totalPrice;

        }

        
        public override string ToString()
        {
            return $"\n{pizza.ToString()} \nPrice for delivery: {deliveryCost} kr. \nTotal price including tax = {CalculateTotalPrice()} kr\n{customer.ToString()}";
        }
    }
}
