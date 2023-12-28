using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2OOP
{
    public class Product
    {
        private string name;
        private Money price;

        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public void DecreasePrice(int reductionDollars, int reductionCents)
        {
            int currentDollars = price.Dollars;
            int currentCents = price.Cents;

            int newCents = currentCents - reductionCents;
            int newDollars = currentDollars - reductionDollars;

            if (newCents < 0)
            {
                newCents += 100;
                newDollars -= 1;
            }

            if (newDollars < 0 || newCents < 0)
            {
                Console.WriteLine("Cannot reduce the price beyond zero.");
            }
            else
            {
                price.Dollars = newDollars;
                price.Cents = newCents;
                Console.WriteLine($"Price of {name} reduced to: {newDollars} dollars and {newCents} cents");
            }
        }
    }
}
