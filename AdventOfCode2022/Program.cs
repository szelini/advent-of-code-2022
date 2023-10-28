using AdventOfCode2022.Day1;

namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Day1
            Day1Solver day1 = new Day1Solver("Day1/input.txt");
            Console.WriteLine(day1.SolvePart1());
            Console.WriteLine(day1.SolvePart2());
        }
    }
}