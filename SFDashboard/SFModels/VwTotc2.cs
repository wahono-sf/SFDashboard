using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTotc2
    {
        [Column("Trip Code")]
        [StringLength(15)]
        public string TripCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Delivery Status")]
        [StringLength(3)]
        public string? DeliveryStatus { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [Column("From Code")]
        [StringLength(10)]
        public string? FromCode { get; set; }
        [Column("From Name")]
        [StringLength(80)]
        public string? FromName { get; set; }
        [Column("From Address 1")]
        [StringLength(45)]
        public string? FromAddress1 { get; set; }
        [Column("From Address 2")]
        [StringLength(45)]
        public string? FromAddress2 { get; set; }
        [Column("From Address 3")]
        [StringLength(45)]
        public string? FromAddress3 { get; set; }
        [Column("From Address 4")]
        [StringLength(45)]
        public string? FromAddress4 { get; set; }
        [Column("Goods Description")]
        [StringLength(45)]
        public string? GoodsDescription { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        public int? Pcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("To Code")]
        [StringLength(10)]
        public string? ToCode { get; set; }
        [Column("To Name")]
        [StringLength(80)]
        public string? ToName { get; set; }
        [Column("To Address 1")]
        [StringLength(45)]
        public string? ToAddress1 { get; set; }
        [Column("To Address 2")]
        [StringLength(45)]
        public string? ToAddress2 { get; set; }
        [Column("To Address 3")]
        [StringLength(45)]
        public string? ToAddress3 { get; set; }
        [Column("To Address 4")]
        [StringLength(45)]
        public string? ToAddress4 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
    }
}
