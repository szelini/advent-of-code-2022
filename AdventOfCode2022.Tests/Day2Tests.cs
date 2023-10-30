using AdventOfCode2022.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    public class Day2Tests
    {
        string[] testInput;

        [SetUp]
        public void Setup()
        {
            testInput = new[]
            {
                "A Y", "B X", "C Z"
            };


        }

        [Test]
        public void Part1_ReturnsCorrectResult()
        {
            Day2Solver day2 = new Day2Solver()
            {
                Rounds = testInput
            };

            int actual = day2.SolvePart1();
            int expected = 15;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Part2_ReturnsCorrectResult()
        {
            Day2Solver day2 = new Day2Solver()
            {
                Rounds = testInput
            };

            int actual = day2.SolvePart2();
            int expected = 12;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
