namespace CMCS.Models
{
    public class SupportingDocument
    {
        public int DocumentID { get; set; }
        public int ClaimID { get; set; }
        public string? DocumentPath { get; set; }

        // Many-to-One relationship with Claim
        public Claim? Claim { get; set; }
    }
}
