using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingWebsite.Classes
{
    public class Request
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Description { get; set; }
        [Required]
        [StringLength(80)]
        public string Justification { get; set; }
        [StringLength(80)]
        public string RejectionReason { get; set; }
        [Required]
        [StringLength(20)]
        public string DevliveryMode { get; set; } = "pickup";
        [Required]
        [StringLength(30)]
        public string Status { get; set; } = "New";
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; } = 0;
        public int GuestId { get; set; }
        public virtual Guest Guest { get; set; }


        public Request()
        {

        }
    }
}
