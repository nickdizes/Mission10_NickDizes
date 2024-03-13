using System.ComponentModel.DataAnnotations;

namespace mission10.Data
{
    public class Team
    {
       [Key]
       public int TeamId { get; set; }
       public string TeamName { get; set; } = null!;
       public int? CaptainId { get; set; }
    }
}
