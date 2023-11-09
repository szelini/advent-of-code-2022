using AdventOfCode2022.Day3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    public class Day3Tests
    {
        string[] testInput;

        [SetUp]
        public void Setup()
        {
            testInput = new[]
            {
                "vJrwpWtwJgWrhcsFMMfFFhFp", 
                "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", 
                "PmmdzqPrVvPwwTWBwg",
                "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
                "ttgJtRGJQctTZtZT",
                "CrZsJsPPZsGzwwsLwLmpwMDw"
            };


        }

        [Test]
        public void Part1_ReturnsCorrectResult()
        {
            Day3Solver day3 = new Day3Solver()
            {
                Rucksacks = testInput
            };

            int actual = day3.SolvePart1();
            int expected = 157;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Part2_ReturnsCorrectResult()
        {
            Day3Solver day3 = new Day3Solver()
            {
                Rucksacks = testInput
            };

            int actual = day3.SolvePart2();
            int expected = 70;

            Assert.That(actual, Is.EqualTo(expected));
        }


    }
}
