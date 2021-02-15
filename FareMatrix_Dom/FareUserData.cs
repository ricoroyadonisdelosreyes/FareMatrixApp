using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FareMatrix_Dom
{
    public class FareUserData : FareBaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string ContactNum { get; set; }
        [Required]
        public string Email { get; set; }
       
    }
}
