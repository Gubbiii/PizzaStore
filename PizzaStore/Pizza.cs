using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        private int _price;
        private string _name;
        Topping _topping;


        public Pizza(string name, int price, Topping topping)
        {
            _name = name;
            _price = price;
            _topping = topping;
        }  

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        } 


        public int Price
        { 
        get { return _price + Topping.Price; } 
        private set { _price = value; }
        }

        public Topping Topping
        {
            get { return _topping; }
            private set { _topping = value; }
        }









        public override string ToString() 
        { 
         return $"Name: {_name} - Price: {_price} kr, extra topping: {Topping}";
        }

        
    }
}
