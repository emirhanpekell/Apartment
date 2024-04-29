using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Data.Entities
{
    public class Houses
    {
        [Required]
        public int doorId { get; set; }
        [Required]
        public string familySurname { get; set; }

        public decimal? rentAmount { get; set; }

    }
}
