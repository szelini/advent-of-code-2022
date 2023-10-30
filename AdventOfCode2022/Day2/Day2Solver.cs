using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day2
{
    public class Day2Solver
    {
        public string[] Rounds { get; set; }

        public Day2Solver(string path)
        {
            Rounds = File.ReadAllLines(path);

        }

        public Day2Solver()
        {
                
        }


        public int SolvePart1()
        {
            int score = 0;

            foreach (string s in Rounds) 
            { 
                string first = s.Split(' ')[0];
                string second = s.Split(" ")[1];

                //A for Rock, B for Paper, C for Scissors
                //1 for Rock, 2 for Paper, and 3 for Scissors
                //0 for lost, 3 for draw, 6 for win

                // X Rock, Y Paper, Z Scissors

                if (second == "X") // me: rock
                {
                    score += 1;

                    if (first == "A") // opponent: rock 
                    {
                        score += 3;
                    }

                    else if (first == "B") // opponent: paper 
                    {
                        score += 0;
                    }

                    else // opponent: scissors 
                    {
                        score += 6;
                    }

                }


                else if (second == "Y") // me: paper
                {
                    score += 2;

                    if (first == "A") // opponent: rock 
                    {
                        score += 6;
                    }

                    else if (first == "B") // opponent: paper 
                    {
                        score += 3;
                    }

                    else // opponent: scissors 
                    {
                        score += 0;
                    }

                }

                else // me: scissors
                {
                    score += 3;

                    if (first == "A") // opponent: rock
                    {
                        score += 0;
                    }

                    else if (first == "B") // opponent: paper 
                    {
                        score += 6;
                    }

                    else  // opponent: scissors 
                    {
                        score += 3;
                    }
                }

            }

            return score;
        }

        public int SolvePart2()
        {
            int score = 0;

            foreach (string s in Rounds)
            {
                string first = s.Split(' ')[0];
                string second = s.Split(" ")[1];

                //A for Rock, B for Paper, C for Scissors
                //1 for Rock, 2 for Paper, and 3 for Scissors
                //0 for lost, 3 for draw, 6 for win

                // X I lose, Y draw, Z win

                if (second == "X") 
                {
                    //score += 0;

                    if (first == "A") // opponent: rock => me : scissors
                    {
                        score += 3;
                    }

                    else if (first == "B") // opponent: paper => me : rock
                    {
                        score += 1;
                       
                    }

                    else // opponent: scissors => me : paper
                    {
                        score += 2;
                    }

                }


                else if (second == "Y") 
                {
                    score += 3;

                    if (first == "A") // opponent: rock 
                    {
                        score += 1;
                    }

                    else if (first == "B") // opponent: paper 
                    {
                        score += 2;
                    }

                    else // opponent: scissors 
                    {
                        score += 3;
                    }

                }

                else 
                {
                    score += 6;

                    if (first == "A") // opponent: rock
                    {
                        score += 2;
                    }

                    else if (first == "B") // opponent: paper 
                    {
                        score += 3;
                    }

                    else  // opponent: scissors 
                    {
                        score += 1;
                    }
                }

            }

            return score;
        }


    }
}
