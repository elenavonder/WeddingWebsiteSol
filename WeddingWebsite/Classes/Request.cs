using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Justification { get; set; }
        public string RejectionReason { get; set; }
        public string DevliveryMode { get; set; } = "pickup";
        public string Status { get; set; } = "New";
        public decimal Total { get; set; } = 0;
        public int GuestId { get; set; }
        public virtual Guest Guest { get; set; }


        public Request()
        {

        }
    }
}
