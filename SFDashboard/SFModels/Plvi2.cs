using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plvi2")]
    [Index("AccCode", Name = "INDEX_Plvi2_AccCode")]
    [Index("ItemCode", Name = "INDEX_Plvi2_ItemCode")]
    [Index("JobNo", Name = "INDEX_Plvi2_JobNo")]
    [Index("JobItemTrxNo", Name = "INDEX_plvi2_JobItemTrxNo")]
    public partial class Plvi2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(2)]
        public string? BillType { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(20)]
        public string? CashAdvanceVoucherNo { get; set; }
        [StringLength(20)]
        public string? ContractCode { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? CostAmt { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [StringLength(20)]
        public string? InvoiceRefNo { get; set; }
        public int ItemTrxNo { get; set; }
        public int? JobItemTrxNo { get; set; }
        public int? JobLineItemNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(15)]
        public string? MainAccCode { get; set; }
        [StringLength(255)]
        public string? Plvi2Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        public int? SalesItemTrxNo { get; set; }
        [StringLength(10)]
        public string? SourceRefNo { get; set; }
        [StringLength(1)]
        public string? SplitFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TaxInvoiceDate { get; set; }
        [StringLength(30)]
        public string? TaxInvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TaxInvoiceReceiptDate { get; set; }
        [Column(TypeName = "decimal(17, 5)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? VatAmt { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [StringLength(1)]
        public string? VatRefundDone { get; set; }
        [StringLength(1)]
        public string? VatRefundFlag { get; set; }
        [Column("WHoldTaxCode")]
        [StringLength(3)]
        public string? WholdTaxCode { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Plvi2s")]
        public virtual Plvi1 TrxNoNavigation { get; set; } = null!;
    }
}
