using System.Collections.Generic;
using CommercialOptimiser.Models;

namespace CommercialOptimiser.Data
{
    public class BreaksDataHandler
    {
        public List<Break> GetBreaksList()
        {
            return new List<Break>() {
                new Break{ Id=1, BreaksType = BreaksType.Break_1, Demographic = DemographicsType.W25_30, Rating = 80 },
                new Break{ Id=2, BreaksType = BreaksType.Break_1, Demographic = DemographicsType.M18_35, Rating = 100 },
                new Break{ Id=3, BreaksType = BreaksType.Break_1, Demographic = DemographicsType.T18_40, Rating = 250 },
                new Break{ Id=4, BreaksType = BreaksType.Break_2, Demographic = DemographicsType.W25_30, Rating = 50 },
                new Break{ Id=5, BreaksType = BreaksType.Break_2, Demographic = DemographicsType.M18_35, Rating = 120 },
                new Break{ Id=6, BreaksType = BreaksType.Break_2, Demographic = DemographicsType.T18_40, Rating = 200 },
                new Break{ Id=7, BreaksType = BreaksType.Break_3, Demographic = DemographicsType.W25_30, Rating = 350 },
                new Break{ Id=8, BreaksType = BreaksType.Break_3, Demographic = DemographicsType.M18_35, Rating = 150 },
                new Break{ Id=9, BreaksType = BreaksType.Break_3, Demographic = DemographicsType.T18_40, Rating = 500 }
            };
        }
    }
}
