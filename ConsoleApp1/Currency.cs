using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Currency
    {
        protected string name;
        protected double exRate;
        public Currency() 
        {
            name = "";
            exRate = 0.0;
        }
        public Currency(string name) 
        {
            this.name = name; 
        }
        public Currency(string name, double exRate)
        {
            this.name = name;
            this.exRate = exRate;
        }
        public Currency(Currency other)
        {
            this.name = other.name;
            this.exRate = other.exRate;
        }
        public string GetName()
        {
            return name;
        }
        public double GetExRate()
        {
            return exRate;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetExRate(double exRate)
        {
            this.exRate = exRate;
        }
    }
}
