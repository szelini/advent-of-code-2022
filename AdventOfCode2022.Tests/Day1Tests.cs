using AdventOfCode2022.Day1;

namespace AdventOfCode2022.Tests
{
    public class Tests
    {
        string[] testInput;

        [SetUp]
        public void Setup()
        {
            testInput = new[]
            {
                "1000", "2000", "3000", "", "4000", "", "5000", "6000", "", "7000", "8000", "9000", "", "10000"
            };

            
        }

        [Test]
        public void Part1_ReturnsCorrectResult()
        {
            Day1Solver day1 = new Day1Solver(testInput);
            int actual = day1.SolvePart1();
            int expected = 24000;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Part2_ReturnsCorrectResult()
        {
            Day1Solver day1 = new Day1Solver(testInput);
            int actual = day1.SolvePart2();
            int expected = 45000;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}