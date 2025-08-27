using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sebl6")]
    public partial class Sebl6
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(4000)]
        public string? ShippingDescription { get; set; }
    }
}
