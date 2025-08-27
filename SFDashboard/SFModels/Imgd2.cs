using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imgd2")]
    public partial class Imgd2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(25)]
        public string? Grade { get; set; }
        public int? LooseQty { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
        public int? MovementTrxNo { get; set; }
        [StringLength(25)]
        public string? NewGrade { get; set; }
        public int? PackingQty { get; set; }
        public int? ProductTrxNo { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
    }
}
