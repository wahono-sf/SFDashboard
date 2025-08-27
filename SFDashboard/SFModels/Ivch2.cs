using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ivch2")]
    public partial class Ivch2
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        public int? Pcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? VatAmt { get; set; }
        [StringLength(255)]
        public string? CostRemark { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        [StringLength(50)]
        public string? WorkStation { get; set; }

        [ForeignKey("CurrCode")]
        [InverseProperty("Ivch2s")]
        public virtual Glex1? CurrCodeNavigation { get; set; }
        [ForeignKey("ItemCode")]
        [InverseProperty("Ivch2s")]
        public virtual Acit1? ItemCodeNavigation { get; set; }
        [ForeignKey("TrxNo")]
        [InverseProperty("Ivch2s")]
        public virtual Ivch1 TrxNoNavigation { get; set; } = null!;
        [ForeignKey("UomCode")]
        [InverseProperty("Ivch2s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
        [ForeignKey("VatCode")]
        [InverseProperty("Ivch2s")]
        public virtual Acva1? VatCodeNavigation { get; set; }
    }
}
