using career_pipeline_domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career_pipeline_domain.Entities
{
    public class ApplicationHistory
    {
        public int Id { get; set; }
        public int JobApplicationId { get; set; }
        public ApplicationStatus OldStatus { get; set; }
        public ApplicationStatus NewStatus { get; set; }
        public DateTime ChangedAt { get; set; }
    }
}
