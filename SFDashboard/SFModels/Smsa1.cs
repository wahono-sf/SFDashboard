using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smsa1")]
    public partial class Smsa1
    {
        public Smsa1()
        {
            Smsa2s = new HashSet<Smsa2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string SalesmanCode { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? ClosedDate { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTime { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? EstSalesAmt { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [StringLength(250)]
        public string? Note { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(20)]
        public string? Stage { get; set; }
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
        public virtual ICollection<Smsa2> Smsa2s { get; set; }
    }
}
