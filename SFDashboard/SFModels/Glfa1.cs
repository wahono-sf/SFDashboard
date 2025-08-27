using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glfa1")]
    [Index("AssetCode", Name = "IX_glfa1", IsUnique = true)]
    public partial class Glfa1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? AccumDepreciationAccCode { get; set; }
        [StringLength(15)]
        public string? AssetAccCode { get; set; }
        [StringLength(10)]
        public string AssetCode { get; set; } = null!;
        [StringLength(50)]
        public string? AssetName { get; set; }
        [StringLength(5)]
        public string? AssetType { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(15)]
        public string? DepreciationAccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? DepreciationAmt { get; set; }
        public int? DepreciationBalancePeriod { get; set; }
        [StringLength(15)]
        public string? DisposalAccCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DisposalDate { get; set; }
        [StringLength(1)]
        public string? DisposalFlag { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? DisposalValue { get; set; }
        [StringLength(15)]
        public string? GainOrLossAccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InitialAssetBalance { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        [StringLength(50)]
        public string? ModelNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextJournalDate { get; set; }
        public int? NoOfDepreciationPeriod { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? PurchaseAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PurchaseDate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ResidueAmt { get; set; }
        [StringLength(50)]
        public string? SerialNo { get; set; }
        [StringLength(50)]
        public string? UserName { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(50)]
        public string? VendorName { get; set; }
        [StringLength(50)]
        public string? WarrantyPeriod { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
