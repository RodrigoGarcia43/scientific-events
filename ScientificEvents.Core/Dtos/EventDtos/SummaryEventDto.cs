using System.Collections.Generic;
using System;

namespace ScientificEvents.Core.Dtos
{
    public  class SummaryEventDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string EventTypeName { get; set; }   
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}