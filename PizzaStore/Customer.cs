using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    public class Customer
    {
        private string _name; //instans variabel
        private string _adress;
        private int _phoneNumber;



        public Customer(string name, string adress, int phonenumber) //constructor
        {
            _name = name;
            _adress = adress;
            _phoneNumber = phonenumber;
        }

        

        public string CostumerName //property
        {
            get { return _name; }
            private set { _name = value; }
        }

        public string Adress
        {
            get { return _adress; }
            private set { _adress = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            private set { _phoneNumber = value; }
        }




        public override string ToString() //metode
        {
            return $"Customer name: {_name}, with phone number: {PhoneNumber} - delivery to adress: {Adress}";
        }
    }
}
