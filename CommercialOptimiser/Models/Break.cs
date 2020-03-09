namespace CommercialOptimiser.Models
{
    public class Break
    {
        public int Id { get; set; }
        public BreaksType BreaksType { get; set; }
        public DemographicsType Demographic { get; set; }
        public int Rating { get; set; }
    }
}
