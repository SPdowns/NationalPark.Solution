using System.ComponentModel.DataAnnotations;

namespace NationalPark.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    public string Description { get; set; }
    public string DateEstablished  { get; set; }
    public string Image  { get; set; }
  }
}