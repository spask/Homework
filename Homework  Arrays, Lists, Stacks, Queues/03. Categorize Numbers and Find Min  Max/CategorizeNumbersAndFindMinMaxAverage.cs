using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class CategorizeNumbersAndFindMinMaxAverage
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal[] numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        List<decimal> roundNums = new List<decimal>();
        List<decimal> floadNums = new List<decimal>();
        for (int i = 0; i <numbers.Length ; i++)
        {
            if (numbers[i]%1!=0)
            {
                roundNums.Add(numbers[i]);
            }
            else
            {
                floadNums.Add(numbers[i]);
            }
        }
        Console.WriteLine("["+string.Join(", ",floadNums )+"]->min: {0},max: {1},sum: {2}, avg{3:F2}",floadNums.Min(),floadNums.Max(),floadNums.Sum(),floadNums.Average());
        Console.WriteLine("[" + string.Join(", ", roundNums) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}", roundNums.Min(), roundNums.Max(), (int)roundNums.Sum(), roundNums.Average());
    }
}

