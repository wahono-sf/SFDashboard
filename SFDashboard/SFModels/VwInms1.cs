using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwInms1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [Column("End Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EndDate { get; set; }
        [Column("Insurance Rate", TypeName = "numeric(18, 0)")]
        public decimal? InsuranceRate { get; set; }
        [Column("Min Premium", TypeName = "numeric(18, 0)")]
        public decimal? MinPremium { get; set; }
        [Column("Rate Type")]
        [StringLength(1)]
        public string RateType { get; set; } = null!;
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Transhipment Rate", TypeName = "numeric(18, 0)")]
        public decimal? TranshipmentRate { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
