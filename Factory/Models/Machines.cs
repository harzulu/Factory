using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
    {
      public Machine()
      {
        this.Engineers = new HashSet<EngineerMachine>();
      }

      public int MachineId { get; set; }
      public string Name { get; set; }
      public string MachineType { get; set; }
      public int Age { get; set; }
      public int EngineerId { get; set; }

      public virtual ICollection<EngineerMachine> Engineers { get; set; }
    }
}