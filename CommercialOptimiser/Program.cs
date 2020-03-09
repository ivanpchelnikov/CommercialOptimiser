using System;
using System.Collections.Generic;
using System.Linq;
using CommercialOptimiser.Data;
using CommercialOptimiser.Models;

namespace CommercialOptimiser
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCommerciala = new CommercialsDataHandler().GetCommercialsList();
            var listOfBreaks = new BreaksDataHandler().GetBreaksList();


            //**** Defualt input  3 Commecials per break ****
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n**** Default input  3 Commecials per break ****  ");
            Console.ResetColor();
            var limitPerBreak1 = new Dictionary<BreaksType, int>()
            {
                { BreaksType.Break_1, 3},
                { BreaksType.Break_2, 3},
                { BreaksType.Break_3, 3}
            };
            var listperDemografic1 = CommercialOptimiser.GetCommercialByDemographic(limitPerBreak1, listOfBreaks, listOfCommerciala);
            foreach (var col in listperDemografic1)
            {
                col.Print();
            }

            //**** Uneven input  2,3,4 Commecials per break ****
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \n**** Uneven Break structure  One break takes 2, one 3 and one 4 Commercials ****  ");
            Console.ResetColor();

            var limitPerBreak2 = new Dictionary<BreaksType, int>()
            {
                { BreaksType.Break_1, 2},
                { BreaksType.Break_2, 3},
                { BreaksType.Break_3, 4}
            };
            var listperDemografic2 = CommercialOptimiser.GetCommercialByDemographic(limitPerBreak2, listOfBreaks, listOfCommerciala);
            foreach (var col in listperDemografic2)
            {
                col.Print();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n**** You have 10 commercials and you must leave one unplaced. ****   ");
            Console.ResetColor();
            var tempList = listperDemografic1.SelectMany(v => v.OptimsedCommercials.Values.SelectMany(v => v));
            foreach (var com in listOfCommerciala)
            {
                if (tempList.FirstOrDefault(c => c.Id == com.Id) == null)
                {
                    Console.WriteLine($"\n The following Commercial is unplaced: {com.Demographic}-{com.Name}-{com.Type}");
                }
            }
            Console.ReadKey();
        }
    }
}
