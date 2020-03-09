using System;
using System.Collections.Generic;
using System.Linq;

namespace CommercialOptimiser.Models
{
    public static class Rules
    {
        public static Func<Break, Commercial, bool> FilterPerBreakRule =
            (Break _break, Commercial _commercial) => _break.BreaksType != BreaksType.Break_2 || _commercial.Type != CommersialTypes.Finance;

        public static Func<int, IEnumerable<Commercial>, List<Commercial>> SortBySameTypeRule = (int limit, IEnumerable<Commercial> _innList) =>
        {
            var result = new List<Commercial>();
            var groupedCommsercials = _innList.GroupBy(com => com.Type, (key, g) => new { GroupName = key, Commercials = g, Count = g.Count() }).OrderByDescending(gr => gr.Count).ToList();

            var element = 0;
            var groupPosition = 0;
            var numberOfGroups = groupedCommsercials.Count;
            for (int i = 0; i < limit; i++)
            {
                for (int y = groupPosition; y < numberOfGroups; y++)
                {
                    if (groupedCommsercials[y].Commercials.Count() < element)
                    {
                        if (y >= 1)
                        {
                            numberOfGroups -= 1;
                            groupPosition = 0;
                            continue;
                        }
                        else if (y == 1)
                        {
                            numberOfGroups = groupedCommsercials.Count;
                            element = 0;
                            break;
                        }
                    }
                    var toAdd = groupedCommsercials[y].Commercials.ElementAt(element);
                    result.Add(toAdd);
                    groupPosition = y + 1;
                    break;
                }
                if (groupPosition == numberOfGroups)
                {
                    element = 0;
                    groupPosition = 0;
                }

            }
            return result.ToList();
        };
    }
}
