using career_pipeline_domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career_pipeline_domain.Entities
{
    public class JobApplication
    {
        public required int Id { get; set; }
        public required int CompanyId { get; set; }
        public required string RoleTitle { get; set; }
        public required string Location { get; set; }
        public required ApplicationStatus Status { get; set; }
        public required ApplicationSource Source { get; set; }
        public required string SalaryRange { get; set; }
        public required string Notes { get; set; }
    }
}
