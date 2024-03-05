using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Topping
    {
        private int _price;
        private string _name;
        



        public Topping(string name, int price)
        {
            _name = name;
            _price = price;

        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }


        public int Price
        {
            get { return _price; }
            private set { _price = value; }
        }

        public override string ToString()
        {
            return $"{_name}, price for extra topping: {_price} kr";
        }

    }
}
