using System.Collections.Generic;
using System.Security.Claims;

namespace CMCS.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }

        private string? name;

        public string? GetName()
        {
            return name;
        }

        public void SetName(string? value)
        {
            name = value;
        }

        public string? Email { get; set; }
        public decimal HourlyRate { get; set; }

        // One-to-Many relationship with Claim
        public ICollection<Claim>? Claims { get; set; }
    }
}
