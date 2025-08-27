using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtrp1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Report ID")]
        [StringLength(10)]
        public string? ReportId { get; set; }
        [Column("Report Name")]
        [StringLength(50)]
        public string? ReportName { get; set; }
        [Column("From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FromDate { get; set; }
        [Column("To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ToDate { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
    }
}
