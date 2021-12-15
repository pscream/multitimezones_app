using System;

namespace WebApi.Models
{

     public class User
    {
        
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public bool IsActive { get; set; }

    }

}