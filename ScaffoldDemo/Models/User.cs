using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldDemo.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}
