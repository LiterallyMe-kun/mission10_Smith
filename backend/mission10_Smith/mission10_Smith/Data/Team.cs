using System.ComponentModel.DataAnnotations;

namespace mission10_Smith.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public int CaptainID { get; set; }
    }
}
