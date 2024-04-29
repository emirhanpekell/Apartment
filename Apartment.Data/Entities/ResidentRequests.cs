using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Data.Entities
{
    public class ResidentRequests
    {
        [Required]
        public int requestId { get; set; }
        [Required]
        public int residentId { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
