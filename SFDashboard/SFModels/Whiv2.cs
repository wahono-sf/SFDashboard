using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("whiv2")]
    public partial class Whiv2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? ItemType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        public int? NoOfCycle { get; set; }
        public int? Pcs { get; set; }
        [StringLength(50)]
        public string? ProductCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? Uom { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [StringLength(50)]
        public string? WorkStation { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Whiv2s")]
        public virtual Whiv1 TrxNoNavigation { get; set; } = null!;
    }
}
