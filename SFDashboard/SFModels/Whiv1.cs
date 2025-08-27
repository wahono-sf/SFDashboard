using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("whiv1")]
    [Index("InvoiceNo", Name = "IX_whiv1")]
    public partial class Whiv1
    {
        public Whiv1()
        {
            Whiv2s = new HashSet<Whiv2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [StringLength(20)]
        public string? BatchNo { get; set; }
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CashAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CashLocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? ChargeRate { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? ChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChequeAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChequeLocalAmt { get; set; }
        [StringLength(18)]
        public string? ChequeNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [StringLength(60)]
        public string? Footer1 { get; set; }
        [StringLength(60)]
        public string? Footer2 { get; set; }
        [StringLength(60)]
        public string? Footer3 { get; set; }
        [StringLength(60)]
        public string? Footer4 { get; set; }
        [StringLength(60)]
        public string? Footer5 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription1 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription2 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription3 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription4 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [StringLength(1)]
        public string? InvoiceType { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PeriodFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PeriodToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(3)]
        public string? TermCode { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [StringLength(50)]
        public string? YourRefNo { get; set; }
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

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Whiv2> Whiv2s { get; set; }
    }
}
