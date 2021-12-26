using System;

namespace WebApi.Models.Requests.Projects
{
    public class CreateProject
    {

        public string Code { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}