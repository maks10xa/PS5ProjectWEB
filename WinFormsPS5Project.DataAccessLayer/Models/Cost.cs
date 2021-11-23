#nullable disable

namespace WinFormsPS5Project.DataAccessLayer.Models
{
    public partial class Cost
    {
        public int Id { get; set; }
        public string TimePeriod { get; set; }
        public decimal? CostOfPeriod { get; set; }
    }
}
