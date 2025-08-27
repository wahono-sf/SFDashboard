using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSibl10
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Shipping Description")]
        [StringLength(4000)]
        public string? ShippingDescription { get; set; }
    }
}
