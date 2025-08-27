using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobPlAccrualActualByJobItemTrxNoByItem
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Document No")]
        [StringLength(20)]
        public string? DocumentNo { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Date { get; set; }
        [Column("Party Code")]
        [StringLength(10)]
        public string? PartyCode { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("TYPE")]
        [StringLength(2)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
    }
}
