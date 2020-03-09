using System;
using System.Collections.Generic;
using CommercialOptimiser.Models;

namespace CommercialOptimiser
{
    public class OptimisedComersials
    {
        public DemographicsType Demographic { get; set; }
        public Dictionary<BreaksType, List<Commercial>> OptimsedCommercials { get; set; }
        public int TotalRating { get; set; }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\nFor this demographic: {Demographic.ToString(),20} \n");
            Console.ResetColor();
            Console.WriteLine($"The list of commercials per break for this demographic: \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"Break",-10} {"Commercial",-20} {"Type",-10} \n");
            Console.ResetColor();
            foreach (var _break in OptimsedCommercials)
            {
                Console.WriteLine();
                foreach (var commercial in _break.Value)
                {
                    Console.WriteLine($"{_break.Key,-10} {commercial.Name,-20} {commercial.Type,-10} ");
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nTotal rating for all commercials: {TotalRating}");
            Console.ResetColor();
        }
    }
}
