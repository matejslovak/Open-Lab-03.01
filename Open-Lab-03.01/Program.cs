using System;

namespace Open_Lab_03._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 20, 30 } };
            Console.WriteLine(array[2, 1]);
        }
    }
}