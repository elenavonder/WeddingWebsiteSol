using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingWebsite.Classes
{
    public class Guest
    {
        public int Id { get; set; }
        [Required]
        [StringLength (30)]
        public string Username { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }
        public string  Lastname { get; set; }

        public Guest()
        {

        }
    }
}
