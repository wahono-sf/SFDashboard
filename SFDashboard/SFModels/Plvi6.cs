using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plvi6")]
    public partial class Plvi6
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short DetailLineItemNo { get; set; }
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
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? CostAmt { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
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
        [StringLength(255)]
        public string? Plvi6Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(15, 5)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? VatAmt { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column("WHoldTaxCode")]
        [StringLength(3)]
        public string? WholdTaxCode { get; set; }
    }
}
