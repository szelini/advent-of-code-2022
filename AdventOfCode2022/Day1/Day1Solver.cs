using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day1
{
    public class Day1Solver
    {
        public string[] Calories { get; set; }

        public Day1Solver(string path)
        {
            Calories = File.ReadAllLines(path);

        }
        public Day1Solver()
        {
                
        }

        public int SolvePart1()
        {
            int maxCalories = 0;
            
            int actCalories = 0;

            foreach (string calorieItem in Calories)
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

            foreach (string calorieItem in Calories)
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
