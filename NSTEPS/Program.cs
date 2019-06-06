using System;
using System.Linq;

namespace NSTEPS
{
    public class Program
    {
        static void Main()
        {
            long pointsAmount = Convert.ToInt32(Console.ReadLine());
            for(long i = 0;i<pointsAmount; i++)
            {
                var Point = Console.ReadLine().Split().Select(s => Convert.ToInt64(s)).ToArray();
                if (Point[0] == Point[1])
                {
                    Console.WriteLine(GetValue(new long[] { 0, 0 }, 0, 1, Point));
                }
                else if (Point[0] - 2 == Point[1])
                    Console.WriteLine(GetValue(new long[] { 2, 0 }, 2, 1, Point));
                else
                    Console.Write("No Number\n");
            }
        }

        public static long GetValue(long[] actual, long number, long step,long[] point)
        {
            if (actual[0] == point[0] & actual[1] == point[1])
                return number;
            number += step;
            if (step == 1)
                step = 3;
            else
                step = 1;
            actual[0] += 1;
            actual[1] += 1;

            return GetValue(actual, number, step, point);
        }
    }
}
