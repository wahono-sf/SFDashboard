using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sibl9")]
    public partial class Sibl9
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(2000)]
        public string? ShippingMarkNo { get; set; }
        [StringLength(510)]
        public string? ShippingPkg { get; set; }
    }
}
