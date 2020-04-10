using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCheckout.Models
{
    public class Book
    {       
            public int Id { get; set; }
            public string Name { get; set; }

    }

    public class Customer

    {

        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public String email { get; set; }
        public Address HomeAddress { get; set; }
        public bool IsMember { get; set; }
     
    }


    public class Address

    {

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

    }
    
}
