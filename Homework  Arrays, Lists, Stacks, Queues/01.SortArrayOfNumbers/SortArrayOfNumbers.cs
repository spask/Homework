using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbers
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        int[] array = numbers.Split().Select(int.Parse).ToArray();
        Array.Sort(array);
        foreach (var arra in array)
        {
            Console.Write(arra+" ");
        }
    }
}

