namespace CMCS.Models
{
    public class AcademicManager
    {
        public int AcademicManagerID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        // One-to-Many relationship with Claim
        public ICollection<Claim>? Claims { get; set; }
    }
}
