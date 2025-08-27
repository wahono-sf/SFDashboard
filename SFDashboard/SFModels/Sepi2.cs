using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sepi2")]
    public partial class Sepi2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }

        [ForeignKey("CurrCode")]
        [InverseProperty("Sepi2s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
        [ForeignKey("ItemCode")]
        [InverseProperty("Sepi2s")]
        public virtual Acit1? ItemCodeNavigation { get; set; }
        [ForeignKey("TrxNo")]
        [InverseProperty("Sepi2s")]
        public virtual Sepi1 TrxNoNavigation { get; set; } = null!;
        [ForeignKey("UomCode")]
        [InverseProperty("Sepi2s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
    }
}
