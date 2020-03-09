namespace CommercialOptimiser.Models
{
    public class Commercial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CommersialTypes Type { get; set; }
        public DemographicsType Demographic { get; set; }
    }
}
