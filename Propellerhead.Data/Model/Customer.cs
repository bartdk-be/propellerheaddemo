using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Propellerhead.Data.Model
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Notes = new List<CustomerNote>();
        }

        [MaxLength(250)]
        public string Identifier { get; set; }

        public DateTime CreationDate { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string FirstName { get; set; }

        [MaxLength(250)]
        public string Street { get; set; }
        [MaxLength(250)]
        public string Number { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }

        [EnumDataType(typeof(CustomerStatus))]
        public CustomerStatus CustomerStatus { get; set; }

        public List<CustomerNote> Notes { get; set; }
    }
}