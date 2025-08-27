using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("totc2")]
    public partial class Totc2
    {
        [Key]
        [StringLength(15)]
        public string TripCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(3)]
        public string? DeliveryStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [StringLength(10)]
        public string? FromCode { get; set; }
        [StringLength(80)]
        public string? FromName { get; set; }
        [StringLength(50)]
        public string? FromAddress1 { get; set; }
        [StringLength(50)]
        public string? FromAddress2 { get; set; }
        [StringLength(50)]
        public string? FromAddress3 { get; set; }
        [StringLength(50)]
        public string? FromAddress4 { get; set; }
        [StringLength(45)]
        public string? GoodsDescription { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        public int? Pcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? ToCode { get; set; }
        [StringLength(80)]
        public string? ToName { get; set; }
        [StringLength(50)]
        public string? ToAddress1 { get; set; }
        [StringLength(50)]
        public string? ToAddress2 { get; set; }
        [StringLength(50)]
        public string? ToAddress3 { get; set; }
        [StringLength(50)]
        public string? ToAddress4 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
    }
}
