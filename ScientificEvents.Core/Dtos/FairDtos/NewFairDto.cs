using System.Collections.Generic;

namespace ScientificEvents.Core.Dtos
{
    public class NewFairDto
    {       
    public string EventCode { get; set; }
    public ICollection<string> StandsCodes { get; set; }   
    }
}