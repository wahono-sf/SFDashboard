using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlfa1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Accum Depreciation Acc Code")]
        [StringLength(15)]
        public string? AccumDepreciationAccCode { get; set; }
        [Column("Asset Acc Code")]
        [StringLength(15)]
        public string? AssetAccCode { get; set; }
        [Column("Asset Code")]
        [StringLength(10)]
        public string AssetCode { get; set; } = null!;
        [Column("Asset Name")]
        [StringLength(50)]
        public string? AssetName { get; set; }
        [Column("Asset Type")]
        [StringLength(5)]
        public string? AssetType { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Depreciation Acc Code")]
        [StringLength(15)]
        public string? DepreciationAccCode { get; set; }
        [Column("Depreciation Amt", TypeName = "decimal(17, 2)")]
        public decimal? DepreciationAmt { get; set; }
        [Column("Depreciation Balance Period")]
        public int? DepreciationBalancePeriod { get; set; }
        [Column("Disposal Acc Code")]
        [StringLength(15)]
        public string? DisposalAccCode { get; set; }
        [Column("Disposal Date", TypeName = "datetime")]
        public DateTime? DisposalDate { get; set; }
        [Column("Disposal Flag")]
        [StringLength(1)]
        public string? DisposalFlag { get; set; }
        [Column("Gain Or Loss Acc Code")]
        [StringLength(15)]
        public string? GainOrLossAccCode { get; set; }
        [Column("Initial Asset Balance", TypeName = "decimal(17, 2)")]
        public decimal? InitialAssetBalance { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        [Column("Model No")]
        [StringLength(50)]
        public string? ModelNo { get; set; }
        [Column("Next Journal Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NextJournalDate { get; set; }
        [Column("No Of Depreciation Period")]
        public int? NoOfDepreciationPeriod { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Purchase Amt", TypeName = "decimal(17, 2)")]
        public decimal? PurchaseAmt { get; set; }
        [Column("Purchase Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PurchaseDate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Residue Amt", TypeName = "decimal(17, 2)")]
        public decimal? ResidueAmt { get; set; }
        [Column("Serial No")]
        [StringLength(50)]
        public string? SerialNo { get; set; }
        [Column("User Name")]
        [StringLength(50)]
        public string? UserName { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(50)]
        public string? VendorName { get; set; }
        [Column("Warranty Period")]
        [StringLength(50)]
        public string? WarrantyPeriod { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(19)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(19)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
