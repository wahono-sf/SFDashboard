using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("topv2")]
    public partial class Topv2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(15)]
        public string? ContainerNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(15)]
        public string? DriverNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(10)]
        public string? OnBehalfOf { get; set; }
        [StringLength(1)]
        public string? PostToProvisionFlag { get; set; }
        [StringLength(12)]
        public string? PrimeMoverNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(1)]
        public string? RecoverableFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(12)]
        public string? TrailerNo { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? VatAmt { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Topv2s")]
        public virtual Topv1 TrxNoNavigation { get; set; } = null!;
    }
}
