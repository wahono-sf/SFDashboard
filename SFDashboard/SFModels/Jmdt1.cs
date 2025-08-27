using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmdt1")]
    public partial class Jmdt1
    {
        public Jmdt1()
        {
            Jmdt2s = new HashSet<Jmdt2>();
            Jmdt3s = new HashSet<Jmdt3>();
            Jmdt4s = new HashSet<Jmdt4>();
        }

        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column("HAwbOrHBlNo")]
        [StringLength(30)]
        public string? HawbOrHblNo { get; set; }
        [Column("MAwbOrOBlNo")]
        [StringLength(30)]
        public string? MawbOrOblNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SalesOrCostItemCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SellTotalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalProvisionCostAmt { get; set; }
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

        [InverseProperty("JobNoNavigation")]
        public virtual ICollection<Jmdt2> Jmdt2s { get; set; }
        [InverseProperty("JobNoNavigation")]
        public virtual ICollection<Jmdt3> Jmdt3s { get; set; }
        [InverseProperty("JobNoNavigation")]
        public virtual ICollection<Jmdt4> Jmdt4s { get; set; }
    }
}
