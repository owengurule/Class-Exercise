using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace october25th2014.Models
{
    [MetadataType(typeof(DonorValidation))]
    public partial class Donor
    {
    }

    public class DonorValidation
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string BloodType { get; set; }

        [Required]
        public string MedicalReport { get; set; }

        [Required]
        public string Address { get; set; }
        
        [Required]
        public string ContactNumber { get; set; }
    }
}