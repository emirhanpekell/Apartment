using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Data.Entities
{
    public class ApartmentResidents
    {
        [Required]
        public int residentId { get; set; }
        [Required]
        public string residentName {get; set; }
        [Required]
        public string residentSurname { get; set; }
        public byte? residentAge { get; set; }
        [Required]
        public byte doorId { get; set; }

    }
}
