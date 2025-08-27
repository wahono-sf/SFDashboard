using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sepv2")]
    [Index("AccCode", Name = "IX_sepv2")]
    [Index("ItemCode", Name = "IX_sepv2_1")]
    public partial class Sepv2
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
        [StringLength(30)]
        public string? JobNo { get; set; }
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
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? VatAmt { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column("WHoldTaxCode")]
        [StringLength(3)]
        public string? WholdTaxCode { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Sepv2s")]
        public virtual Sepv1 TrxNoNavigation { get; set; } = null!;
    }
}
