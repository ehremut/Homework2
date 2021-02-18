using System;
using System.IO;
using System.Linq;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(args[0]);
            var numbers = Array.ConvertAll(lines, int.Parse);
            int second = numbers.OrderByDescending(x => x).ElementAt(1);
            Console.WriteLine(second);
        }
    }
}