namespace HW3T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 2, 1, 5, 4 };
            MyArray myArr = new MyArray(numbers);

            myArr.Show();
            myArr.Show("Testing message");

            Console.WriteLine("Max: " + myArr.Max());
            Console.WriteLine("Min: " + myArr.Min());
            Console.WriteLine("Avg: " + myArr.Avg());
            int valueToSearch = 3;
            Console.WriteLine($"Is {valueToSearch} included: {myArr.Search(valueToSearch)}");
            valueToSearch = 8;
            Console.WriteLine($"Is {valueToSearch} included: {myArr.Search(valueToSearch)}");

            myArr.SortAsc();
            Console.WriteLine("Sorted by ASC:");
            myArr.Show();

            myArr.SortDesc();
            Console.WriteLine("Sorted by DESC:");
            myArr.Show();

            bool isAsc = false;
            myArr.SortByParam(isAsc);
            Console.WriteLine($"Sorted by isAsc patameter {isAsc}:");
            myArr.Show();
        }
    }
}