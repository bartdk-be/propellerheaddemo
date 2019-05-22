using System;
using System.ComponentModel.DataAnnotations;

namespace Propellerhead.Data.Model
{
    public class CustomerNote : BaseEntity
    {
        [MaxLength(5000)]
        public string Note { get; set; }

        public Guid CustomerId { get; set; }
    }
}