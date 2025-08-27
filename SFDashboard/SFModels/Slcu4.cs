using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slcu4")]
    public partial class Slcu4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
    }
}
