using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmtx5
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [StringLength(1500)]
        public string? Cost { get; set; }
        [Column("Railing Remark")]
        [StringLength(1000)]
        public string? RailingRemark { get; set; }
        [StringLength(1500)]
        public string? Selling { get; set; }
    }
}
