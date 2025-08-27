using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmcs1")]
    public partial class Jmcs1
    {
        [Key]
        [Column("KeyID")]
        public int KeyId { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerOrVendorCode { get; set; }
        [StringLength(80)]
        public string? CustomerOrVendorName { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ForeignAmt { get; set; }
        [Column("HawbOrHBlNo")]
        [StringLength(30)]
        public string? HawbOrHblNo { get; set; }
        [StringLength(18)]
        public string? InvoiceChequeNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JournalDate { get; set; }
        [StringLength(12)]
        public string? JournalNo { get; set; }
        [Column("MawbOrOBlNo")]
        [StringLength(30)]
        public string? MawbOrOblNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
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

        [ForeignKey("AccCode")]
        [InverseProperty("Jmcs1s")]
        public virtual Glch1? AccCodeNavigation { get; set; }
    }
}
