using System;

namespace WebApi.Models.Database
{

    public class Ticket
    {

        public Guid Id { get; set; }

        public Guid ProjectId { get; set; }

        public Project Project { get; set; }

        public string Code { get; set; }

        public DateTime? TransactionDate { get; set; }

        public DateTimeOffset? ReceivedOn { get; set; }
        public DateTime? ReceivedOnUtc { get; set; }

        public DateTimeOffset? UpdatedOn { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public Guid UpdatedById { get; set; }
        public User UpdatedBy { get; set; }

        public bool IsActive { get; set; }

    }

}