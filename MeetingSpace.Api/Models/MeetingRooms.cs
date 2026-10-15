using System.ComponentModel.DataAnnotations;

namespace MeetingSpace.Api.Models;

public class MeetingRooms
{
  public int Id { get; set; }

  [MaxLength(50)]
  public required string Name { get; set; }

  public int Capacity { get; set; }

  public int Floor { get; set; }

  [MaxLength(250)]
  public required string Description { get; set; } 
}
