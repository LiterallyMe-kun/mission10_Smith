using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission10_Smith.Data
{
    public class Bowler
    {
        [Key]
        public int BowlerId { get; set; }
        [Required]
        public string? BowlerLastName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public int BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }

        [ForeignKey(nameof(Team))]
        public int TeamID { get; set; }
    
        public Team? Team { get; set; }
    
    }
}
