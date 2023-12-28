namespace HW2OOPT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DecimalNumber decimalNum = new DecimalNumber(123);

            decimalNum.ConvertToBinary();        
            decimalNum.ConvertToOctal();        
            decimalNum.ConvertToHexadecimal(); 
        }
    }
}