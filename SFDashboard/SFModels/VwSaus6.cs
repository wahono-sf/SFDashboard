using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaus6
    {
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Frequent Report Trx No")]
        public int? FrequentReportTrxNo { get; set; }
    }
}
