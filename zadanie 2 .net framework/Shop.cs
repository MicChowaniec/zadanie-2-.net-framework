using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie_2.net_framework
{
    public class Shop
    {
        private String name
        {
            get => default;
            set
            {
            }
        }

        private Person[] people
        {
            get => default;
            set
            {
            }
        }

        private Product[] products
        {
            get => default;
            set
            {
            }
        }

        public String Name
        {
            get value;
            set name;
            
            
        }

        public Shop create(string name, Person[] people, Product[] products)
        {
            Shop shop = new Shop();
            shop.name = name;
            shop.people = people;
            shop.products = products;
        }

        public void Print()
        {
            throw new System.NotImplementedException();
        }
    }
}