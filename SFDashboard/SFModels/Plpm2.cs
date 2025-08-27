using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plpm2")]
    [Index("ContraPartyCode", Name = "INDEX_Plpm2_ContraPartyCode")]
    [Index("PaidInvoiceNo", Name = "INDEX_Plpm2_PaidInvoiceNo")]
    [Index("PaidInvoiceTrxNo", Name = "INDEX_Plpm2_PaidInvoiceTrxNo")]
    public partial class Plpm2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(10)]
        public string? ContraPartyCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? DebitLiabAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? DebitLiabLocalAmt { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? DiscountAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? DiscountLocalAmt { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(1)]
        public string? PaidInvoiceFlag { get; set; }
        [StringLength(20)]
        public string? PaidInvoiceNo { get; set; }
        public int? PaidInvoiceTrxNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? PayAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? PayLocalAmt { get; set; }
        [StringLength(2)]
        public string? Prefix { get; set; }
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
