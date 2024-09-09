using System;
using System.Collections.Generic;

namespace CMCS.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int LecturerID { get; set; }
        public int ProgramCoordinatorID { get; set; }
        public int AcademicManagerID { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal TotalAmount { get; set; }
        public string? ClaimStatus { get; set; }
        public DateTime SubmissionDate { get; set; }

        // Relationships
        public Lecturer? Lecturer { get; set; }
        public ProgramCoordinator? ProgramCoordinator { get; set; }
        public AcademicManager? AcademicManager { get; set; }

        // One-to-Many relationship with SupportingDocument
        public ICollection<SupportingDocument>? SupportingDocuments { get; set; }
    }
}
