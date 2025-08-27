using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSebl5
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Shipping Mark No")]
        [StringLength(2000)]
        public string? ShippingMarkNo { get; set; }
        [Column("Shipping Pkg")]
        [StringLength(510)]
        public string? ShippingPkg { get; set; }
    }
}
