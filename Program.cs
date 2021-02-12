using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()  //read the entrance
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine(string.Join(' ', nums));
                    break;
                }

                List<string> currCommand = command.Split(' ')
                            .ToList();

                if (currCommand[0] == "Add")
                {
                   //int currNumb = int.Parse(Console.ReadLine());
                    nums.Add(int.Parse(currCommand[1]));
                }

                if (currCommand[0] == "Remove")
                {
                    nums.Remove(int.Parse(currCommand[1]));

                }

                if (currCommand[0] == "RemoveAt")                // 0 1 2
                {
                    nums.RemoveAt(int.Parse(currCommand[1]));  // numb 8 -> index -> 3
                }

                if (currCommand[0] == "Insert")
                {
                    nums.Insert(int.Parse(currCommand[2]), int.Parse(currCommand[1]));
                }
            }
        }
    }
}
