using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaco4
    {
        [Column("Database Name")]
        [StringLength(50)]
        public string DatabaseName { get; set; } = null!;
        [Column("Color Code")]
        [StringLength(50)]
        public string? ColorCode { get; set; }
        [Column("Connection String")]
        [StringLength(100)]
        public string? ConnectionString { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Transfer Costing Flag")]
        [StringLength(1)]
        public string? TransferCostingFlag { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
    }
}
