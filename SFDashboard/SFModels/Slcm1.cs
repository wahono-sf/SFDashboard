using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slcm1")]
    public partial class Slcm1
    {
        public Slcm1()
        {
            Slcm2s = new HashSet<Slcm2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BackupAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BackupEndDate { get; set; }
        [StringLength(1)]
        public string? BackupFlag { get; set; }
        [StringLength(80)]
        public string? BackupInvoiceRemark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BackupStartDate { get; set; }
        [StringLength(3)]
        public string? BillingCycle { get; set; }
        [StringLength(1)]
        public string? CloudFlag { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(80)]
        public string? InvoiceRemark { get; set; }
        [StringLength(80)]
        public string? Module { get; set; }
        public int? NoOfUser { get; set; }
        [StringLength(1000)]
        public string? Note { get; set; }
        [StringLength(80)]
        public string? OthersRemarks { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
        [StringLength(20)]
        public string? Version { get; set; }
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
        public virtual ICollection<Slcm2> Slcm2s { get; set; }
    }
}
