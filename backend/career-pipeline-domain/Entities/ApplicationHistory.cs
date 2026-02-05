using career_pipeline_domain.Enums;

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
