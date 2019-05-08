using System.Collections.Generic;

namespace ScientificEvents.Core.Dtos
{
    public class StandDto
    {       
        public string Code { get; set; }

        public string Location { get; set; }
        public int Area { get; set; }

        public string FairId { get; set; }
        public ICollection<string> ProductsCodes { get; set; }   
    }
}