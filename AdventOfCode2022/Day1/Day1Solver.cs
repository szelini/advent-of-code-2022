using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day1
{
    public class Day1Solver
    {
        private string[] _calories;

        public Day1Solver(string path)
        {
            _calories = File.ReadAllLines(path);

        }

        public Day1Solver(string[] array)
        {
            _calories = array;
        }

        public int SolvePart1()
        {
            int maxCalories = 0;
            
            int actCalories = 0;

            foreach (string calorieItem in _calories)
            {
                if (calorieItem != "")
                {
                    actCalories += int.Parse(calorieItem);
                }
                else
                {
                    maxCalories = Math.Max(maxCalories, actCalories);
                    actCalories = 0;
                }
            }

            maxCalories = Math.Max(maxCalories, actCalories);

            return maxCalories;
        }

        public int SolvePart2()
        {
            List<int> caloriesPerElf = new List<int>(); 
            int actCalories = 0;

            foreach (string calorieItem in _calories)
            {
                if (calorieItem != "")
                {
                    actCalories += int.Parse(calorieItem);
                }
                else
                {
                    caloriesPerElf.Add(actCalories);
                    actCalories = 0;
                }
            }

            caloriesPerElf.Add(actCalories);

            return caloriesPerElf.OrderByDescending(x => x).Take(3).Sum();
        }

    }
}
