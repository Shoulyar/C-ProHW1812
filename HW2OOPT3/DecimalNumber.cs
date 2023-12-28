using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2OOPT3
{
    public struct DecimalNumber
    {
        private int value;

        public DecimalNumber(int value)
        {
            this.value = value;
        }

        public void ConvertToBinary()
        {
            string binary = Convert.ToString(value, 2);
            Console.WriteLine($"Decimal {value} in binary: {binary}");
        }

        public void ConvertToOctal()
        {
            string octal = Convert.ToString(value, 8);
            Console.WriteLine($"Decimal {value} in octal: {octal}");
        }

        public void ConvertToHexadecimal()
        {
            string hex = Convert.ToString(value, 16);
            Console.WriteLine($"Decimal {value} in hexadecimal: {hex}");
        }
    }
}
