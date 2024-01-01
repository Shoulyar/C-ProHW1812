using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3T
{
    public class MyArray : IOutput, IMath, ISort
    {
        private int[] array;

        public MyArray(int[] arr)
        {
            array = arr;
        }

        public void Show()
        {
            Console.WriteLine("Array's elements:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine("Information message: " + info);
        }

        public int Max()
        {
            return array.Max();
        }

        public int Min()
        {
            return array.Min();
        }

        public float Avg()
        {
            return (float)array.Average();
        }

        public bool Search(int valueToSearch)
        {
            return array.Contains(valueToSearch);
        }
        public void SortAsc()
        {
            Array.Sort(array);
        }

        public void SortDesc()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                Array.Sort(array);
            }
            else
            {
                Array.Sort(array);
                Array.Reverse(array);
            }
        }
    }
}
