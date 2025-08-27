using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smfq6")]
    public partial class Smfq6
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
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
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Smfq6s")]
        public virtual Smfq1 TrxNoNavigation { get; set; } = null!;
    }
}
