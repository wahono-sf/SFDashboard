using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sibl4")]
    public partial class Sibl4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int CargoLineItemNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ActualHeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ActualLength { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ActualVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ActualWidth { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? LooseQty { get; set; }
        [StringLength(50)]
        public string? LooseUomCode { get; set; }
        public int? Pcs { get; set; }
        [StringLength(10)]
        public string? PcsPackNo { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Sibl4s")]
        public virtual Sibl1 TrxNoNavigation { get; set; } = null!;
    }
}
