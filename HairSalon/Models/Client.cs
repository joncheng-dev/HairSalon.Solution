using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; } // uppercase and syntax name must match what these are called in the database. Primary key (id number) follows [ClassName]Id syntax.
    public string Name { get; set; }
    public Stylist Stylist { get; set; }
    public int StylistId { get; set; }
  }
}