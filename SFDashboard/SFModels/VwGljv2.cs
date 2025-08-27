using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGljv2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Adjust Flag")]
        [StringLength(1)]
        public string? AdjustFlag { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [Column("Asset Code")]
        [StringLength(10)]
        public string? AssetCode { get; set; }
        [Column("Awb Or Bl No")]
        [StringLength(30)]
        public string? AwbOrBlNo { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Class Code")]
        [StringLength(1)]
        public string? ClassCode { get; set; }
        [Column("Contract Code")]
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Credit Amt", TypeName = "decimal(17, 2)")]
        public decimal? CreditAmt { get; set; }
        [Column("Debit Amt", TypeName = "decimal(17, 2)")]
        public decimal? DebitAmt { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("Gl Acc Code")]
        [StringLength(15)]
        public string? GlAccCode { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Job Item Trx No")]
        public int? JobItemTrxNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Main Acc Code")]
        [StringLength(15)]
        public string? MainAccCode { get; set; }
        [Column("Prepayment Code")]
        [StringLength(10)]
        public string? PrepaymentCode { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Vat Amt", TypeName = "decimal(17, 2)")]
        public decimal? VatAmt { get; set; }
        [Column("Vat Code")]
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column("Vat Type")]
        [StringLength(1)]
        public string? VatType { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
    }
}
