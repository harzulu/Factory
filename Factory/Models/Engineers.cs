using System.Collections.Generic;

namespace Factory.Models
{
  public class Enigneer
    {
      public Engineer()
      {
        this.Machines = new HashSet<EngineerMachine>();
      }

      public int EnigneerId { get; set; }
      public string Name { get; set; }
      public int MachineId { get; set; }

      public virtual ICollection<EnigneerMachine> Machines { get; set; }
    }
}