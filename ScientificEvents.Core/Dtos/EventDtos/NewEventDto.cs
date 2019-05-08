using System.Collections.Generic;

namespace ScientificEvents.Core.Dtos
{
    public class NewEventDto
    {    
    public string Code { get; set; }
    public string Name { get; set; }
    public EventType Type { get; set; }
    public int AdmissionFee { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    }
}