using System.Collections.Generic;
using System.Linq;
using CommercialOptimiser.Models;

namespace CommercialOptimiser
{
    public static class CommercialOptimiser
    {
        public static List<OptimisedComersials> GetCommercialByDemographic(Dictionary<BreaksType, int> limitPerBreak, List<Break> listOfBreaks, List<Commercial> listOfCommerciala)
        {
            var resultLIst = new List<OptimisedComersials>();
            foreach (var _breakLimit in limitPerBreak)
            {
                foreach (var _break in listOfBreaks.Where(br => br.BreaksType == _breakLimit.Key))
                {
                    var currentList = resultLIst.Where(r => r.Demographic == _break.Demographic).FirstOrDefault();
                    if (currentList == null)
                    {
                        currentList = new OptimisedComersials
                        {
                            Demographic = _break.Demographic,
                            OptimsedCommercials = new Dictionary<BreaksType, List<Commercial>>()
                        };
                        resultLIst.Add(currentList);
                    }
                    var GetCommercialPerBreakPerDemographic
                        = listOfCommerciala.Where(com => com.Demographic == _break.Demographic && Rules.FilterPerBreakRule(_break, com));

                    var finalListOfCommercialPerDemog = Rules.SortBySameTypeRule(_breakLimit.Value, GetCommercialPerBreakPerDemographic);

                    currentList.OptimsedCommercials.Add(_break.BreaksType, finalListOfCommercialPerDemog);
                    currentList.TotalRating += finalListOfCommercialPerDemog.Count * _break.Rating;
                }
            }
            return resultLIst;
        }
    }
}
