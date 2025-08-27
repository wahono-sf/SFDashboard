using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("gljv2")]
    public partial class Gljv2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Column("GLAccCode")]
        [StringLength(15)]
        public string? GlaccCode { get; set; }
        [StringLength(1)]
        public string? AdjustFlag { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(10)]
        public string? AssetCode { get; set; }
        [StringLength(30)]
        public string? AwbOrBlNo { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(1)]
        public string? ClassCode { get; set; }
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        public int? JobItemTrxNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(15)]
        public string? MainAccCode { get; set; }
        [StringLength(10)]
        public string? PrepaymentCode { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? VatAmt { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [StringLength(1)]
        public string? VatType { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
    }
}
