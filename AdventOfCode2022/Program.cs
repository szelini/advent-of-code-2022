using AdventOfCode2022.Day1;
using AdventOfCode2022.Day2;
using AdventOfCode2022.Day3;

namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Day1
            //Day1Solver day1 = new Day1Solver("Day1/day1_input.txt");
            //Console.WriteLine(day1.SolvePart1());
            //Console.WriteLine(day1.SolvePart2());

            //// Day2
            //Day2Solver day2 = new Day2Solver("Day2/day2_input.txt");
            //Console.WriteLine(day2.SolvePart1());
            //Console.WriteLine(day2.SolvePart2());

            //Day3
            Day3Solver day3 = new Day3Solver("Day3/day3_input.txt");
            Console.WriteLine(day3.SolvePart1());
            Console.WriteLine(day3.SolvePart2());
        }
    }
}