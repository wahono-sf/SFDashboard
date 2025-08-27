using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aeaw4")]
    public partial class Aeaw4
    {
        [Key]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? ChgRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChgWt { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWt { get; set; }
        [StringLength(1)]
        public string? KgLbFlag { get; set; }
        public int? Pcs { get; set; }
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [StringLength(50)]
        public string? Sector { get; set; }
        [Column("SLACQty", TypeName = "decimal(10, 0)")]
        public decimal? Slacqty { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
    }
}
