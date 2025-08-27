using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smsa2")]
    public partial class Smsa2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(1000)]
        public string? Action { get; set; }
        [StringLength(1000)]
        public string? Conclusion { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTime { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(3000)]
        public string? Discussion { get; set; }
        [StringLength(20)]
        public string? QuotationNo { get; set; }
        [StringLength(25)]
        public string? Reference { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
        [StringLength(5)]
        public string? Type { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Smsa2s")]
        public virtual Smsa1 TrxNoNavigation { get; set; } = null!;
    }
}
