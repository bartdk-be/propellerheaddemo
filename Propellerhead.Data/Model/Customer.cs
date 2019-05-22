using System;
using System.ComponentModel.DataAnnotations;

namespace Propellerhead.Data.Model
{
    public class Customer
    {
        [Key] 
        public Guid  Id { get; set; }

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
    }
}