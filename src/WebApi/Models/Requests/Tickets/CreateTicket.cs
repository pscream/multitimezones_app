using System;

namespace WebApi.Models.Requests.Tickets
{
    public class CreateTicket
    {

        public Guid ProjectId { get; set; }

        public string Code { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTimeOffset ReceivedOn { get; set; }

        public DateTime? ReceivedOnUtc { get; set; }

    }
}