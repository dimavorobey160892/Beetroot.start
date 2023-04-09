using System;
using System.Collections.Generic;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> voteOptions = new Dictionary<string, int>();

            
            Console.Write("Enter vote topic: ");
            string voteTopic = Console.ReadLine();

            
            Console.Write("Enter vote options separated by commas: ");
            string[] options = Console.ReadLine().Split(',');

            
            foreach (string option in options)
            {
                voteOptions.Add(option.Trim(), 0);
            }

            while (true)
            {
                
                Console.WriteLine("Vote options for " + voteTopic + ":");
                foreach (string option in voteOptions.Keys)
                {
                    Console.WriteLine(option);
                }

                
                Console.Write("Enter vote: ");
                string vote = Console.ReadLine();

                
                if (voteOptions.ContainsKey(vote))
                {
                    
                    voteOptions[vote] += 1;
                    Console.WriteLine("Vote recorded!");
                }
                else
                {
                    Console.WriteLine("Invalid vote option!");
                }

                
                Console.Write("Do you want to continue voting? (y/n): ");
                string continueVoting = Console.ReadLine().ToLower();

                if (continueVoting == "n")
                {
                    break;
                }
            }

            
            Console.WriteLine("Voting results for " + voteTopic + ":");
            foreach (var option in voteOptions)
            {
                Console.WriteLine(option.Key + ": " + option.Value);
            }

            Console.ReadLine();
        }
    }
}