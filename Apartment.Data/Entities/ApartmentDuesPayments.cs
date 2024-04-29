using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Data.Entities
{
    public class ApartmentDuesPayments
    {
        [Required]
        public int paymentId { get; set; }
        [Required]
        public decimal duesAmount { get; set; }
        [Required]
        public int doorId { get; set; }
        [Required]
        public DateTime paymentDate { get; set; }
    }
}
