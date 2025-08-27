using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sebk3")]
    public partial class Sebk3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(1)]
        public string? PpCcFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "decimal(15, 5)")]
        public decimal? UnitRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? VatAmt { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }

        [ForeignKey("CurrCode")]
        [InverseProperty("Sebk3s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
        [ForeignKey("TrxNo")]
        [InverseProperty("Sebk3s")]
        public virtual Sebk1 TrxNoNavigation { get; set; } = null!;
        [ForeignKey("UomCode")]
        [InverseProperty("Sebk3s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
        [ForeignKey("VatCode")]
        [InverseProperty("Sebk3s")]
        public virtual Acva1? VatCodeNavigation { get; set; }
    }
}
