using System.Collections.Generic;
using CommercialOptimiser.Models;

namespace CommercialOptimiser.Data
{
    public class CommercialsDataHandler
    {
        public List<Commercial> GetCommercialsList()
        {
            return new List<Commercial>()
            {
                new Commercial { Id =1, Name = "Commercial 1", Demographic = DemographicsType.W25_30, Type= CommersialTypes.Automotive},
                new Commercial { Id =2, Name = "Commercial 2", Demographic = DemographicsType.M18_35, Type= CommersialTypes.Travel},
                new Commercial { Id =3, Name = "Commercial 3", Demographic = DemographicsType.T18_40, Type= CommersialTypes.Travel},
                new Commercial { Id =4, Name = "Commercial 4", Demographic = DemographicsType.M18_35, Type= CommersialTypes.Automotive},
                new Commercial { Id =5, Name = "Commercial 5", Demographic = DemographicsType.M18_35, Type= CommersialTypes.Automotive},
                new Commercial { Id =6, Name = "Commercial 6", Demographic = DemographicsType.W25_30, Type= CommersialTypes.Finance},
                new Commercial { Id =7, Name = "Commercial 7", Demographic = DemographicsType.M18_35, Type= CommersialTypes.Finance},
                new Commercial { Id =8, Name = "Commercial 8", Demographic = DemographicsType.T18_40, Type= CommersialTypes.Automotive},
                new Commercial { Id =9, Name = "Commercial 9", Demographic = DemographicsType.W25_30, Type= CommersialTypes.Travel},
                new Commercial { Id =10, Name = "Commercial 10", Demographic = DemographicsType.T18_40, Type= CommersialTypes.Finance}
            };
        }
    }
}
