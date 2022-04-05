using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldDemo.Models
{
    public partial class Address
    {
        public Address()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public int? PostalCode { get; set; }
        public int? CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
