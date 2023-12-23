using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        protected string name;
        protected double price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected double weight;
        public Product()
        {
            name = "";
            price = 0.0;
            cost = new Currency();
            quantity = 0;
            producer = "";
            weight = 0.0;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            this.name = name;
            this.price = price;
            this.cost = new Currency(cost);
            this.quantity = quantity;
            this.producer = producer;
            this.weight = weight;
        }

        public Product(Product other)
        {
            this.name = other.Name;
            this.price = other.Price;
            this.cost = new Currency(other.Cost);
            this.quantity = other.Quantity;
            this.producer = other.Producer;
            this.weight = other.Weight;
        }
        public string Name 
        { 
            get 
            { 
                return name; 
            } 
            set 
            {  
                name = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public Currency Cost
        {
            get
            {
                return cost;
            }
            set 
            { 
                cost = value; 
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set 
            {
                quantity = value; 
            }
        }
        public string Producer
        {
            get
            {
                return producer;
            }
            set 
            {
                producer = value; 
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public double GetPriceInUAH()
        {
            return price * cost.GetExRate(); 
        }
        public double GetTotalPriceInUAH()
        {
            return price * quantity * cost.GetExRate();  
        }
        public double GetTotalWeight()
        {
            return weight * quantity;
        }
    }
}
