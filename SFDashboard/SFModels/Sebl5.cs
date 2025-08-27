using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sebl5")]
    public partial class Sebl5
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(2000)]
        public string? ShippingMarkNo { get; set; }
        [StringLength(510)]
        public string? ShippingPkg { get; set; }
    }
}
