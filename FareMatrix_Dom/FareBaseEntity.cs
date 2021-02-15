using System;
using System.ComponentModel.DataAnnotations;

namespace FareMatrix_Dom
{
    public class FareBaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Pasword { get; set; }
    
    }

}
