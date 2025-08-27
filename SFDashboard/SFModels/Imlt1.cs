using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imlt1")]
    public partial class Imlt1
    {
        public Imlt1()
        {
            Imlt2s = new HashSet<Imlt2>();
        }

        [Key]
        [StringLength(20)]
        public string LotNo { get; set; } = null!;
        public int? AvailableQty { get; set; }
        public int? AvailableQty1 { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        public int? IncomingQty { get; set; }
        public int? IncomingQty1 { get; set; }
        public int? LooseQty { get; set; }
        public int? OnOrderQty { get; set; }
        [Column("OnOrderQTy1")]
        public int? OnOrderQty1 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PermitDutyAmt { get; set; }
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [StringLength(3)]
        public string? PermitQtyUnit { get; set; }
        public int? PermitUnitWeight { get; set; }
        [StringLength(3)]
        public string? PermitUnitWeightUnit { get; set; }
        public int? PrevQty { get; set; }
        public int? QtyOnHand { get; set; }
        public int? QtyOnHand1 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        public int? ReservedQty { get; set; }
        public int? ReservedQty1 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
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

        [InverseProperty("LotNoNavigation")]
        public virtual ICollection<Imlt2> Imlt2s { get; set; }
    }
}
