using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glfb1")]
    public partial class Glfb1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CurrentBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrEndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12BalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrOpenBalanceAmt { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth01EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth02EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth03EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth04EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth05EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth06EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth07EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth08EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth09EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth10EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth11EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisMth12EndBalanceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrOpenBalanceAmt { get; set; }
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

        [ForeignKey("CurrCode")]
        [InverseProperty("Glfb1s")]
        public virtual Glex1 CurrCodeNavigation { get; set; } = null!;
    }
}
