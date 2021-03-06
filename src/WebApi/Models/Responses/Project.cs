using System;

namespace WebApi.Models.Responses
{
         public class Project
    {
        
        public Guid Id { get; set; }

        public string Code { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTimeOffset? UpdatedOn { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public Guid UpdatedById { get; set; } 
        public User UpdatedBy { get; set; }

        public bool IsActive { get; set; }

    }
}