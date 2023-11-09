using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day3
{
    public class Day3Solver
    {
        public string[] Rucksacks { get; set; }

        public Day3Solver() { }

        public Day3Solver(string path)
        {
            Rucksacks = File.ReadAllLines(path);
        }


        public int SolvePart1()
        {
            int sum = 0;

            foreach (string rs in Rucksacks)
            {
                string compartment1 = rs.Substring(0, rs.Length / 2);
                string compartment2 = rs.Substring(rs.Length / 2);

                char item = compartment1.ToCharArray().Intersect(compartment2.ToCharArray()).FirstOrDefault();

                if (char.IsLower(item))
                {
                    sum += item - 96;
                }
                else
                {
                    sum += item - 38;
                }
            }

            return sum;
        }

        public int SolvePart2()
        {
            int sum = 0;

            for (int i = 0; i < Rucksacks.Length; i+=3)
            {
                char item = Rucksacks[i].ToCharArray().Intersect(Rucksacks[i + 1].ToCharArray()).Intersect(Rucksacks[i + 2].ToCharArray()).FirstOrDefault();
                
                if (char.IsLower(item))
                {
                    sum += item - 96;
                }
                else
                {
                    sum += item - 38;
                }
            }

            return sum;

        }
    }
}
