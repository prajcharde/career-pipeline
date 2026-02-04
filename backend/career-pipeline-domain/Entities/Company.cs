using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career_pipeline_domain.Entities
{
    public class Company
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Website { get; set; }
        public required string Industry { get; set; }
        public required Guid UserId { get; set; }
    }
}
