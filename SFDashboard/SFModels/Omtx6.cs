using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omtx6")]
    public partial class Omtx6
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }

        [ForeignKey("CurrCode")]
        [InverseProperty("Omtx6s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
        [ForeignKey("TrxNo")]
        [InverseProperty("Omtx6s")]
        public virtual Omtx1 TrxNoNavigation { get; set; } = null!;
        [ForeignKey("UomCode")]
        [InverseProperty("Omtx6s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
        [ForeignKey("VatCode")]
        [InverseProperty("Omtx6s")]
        public virtual Acva1? VatCodeNavigation { get; set; }
    }
}
