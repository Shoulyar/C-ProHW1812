using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2OOP
{
    public class Money
    {
        private int dollars;
        private int cents;

        public int Dollars
        {
            get { return dollars; }
            set { dollars = value; }
        }

        public int Cents
        {
            get { return cents; }
            set { cents = value; }
        }

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Amount: {dollars} dollars and {cents} cents");
        }
    }
}
