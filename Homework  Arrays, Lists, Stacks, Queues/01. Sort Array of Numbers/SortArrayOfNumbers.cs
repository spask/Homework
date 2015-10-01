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
        int[] arrey = values.Split().Select(int.Parse).ToArray();
        Array.Sort(arrey);
        foreach (var arre in arrey)
        {
            Console.Write(arre+" ");
        }
    }
}

