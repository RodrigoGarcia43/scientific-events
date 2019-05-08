using System.Collections.Generic;
using System;

namespace ScientificEvents.Core.Dtos
{
    public class NewEventDto
    {    
        public string Name { get; set; }
        public string Type { get; set; }
        public int AdmissionFee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}