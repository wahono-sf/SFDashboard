using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amad2")]
    public partial class Amad2
    {
        [Key]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(3)]
        public string? AwbChargeCode { get; set; }
        [StringLength(1)]
        public string? ChargeType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate01 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate02 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate03 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate04 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate05 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate06 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate07 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate08 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate09 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate10 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate11 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate12 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate13 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate14 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate15 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate16 { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight01 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight02 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight03 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight04 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight05 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight06 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight07 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight08 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight09 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight11 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight12 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight13 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight14 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight15 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight16 { get; set; }
        [StringLength(1)]
        public string? WeightType { get; set; }

        [ForeignKey("BusinessPartyCode")]
        [InverseProperty("Amad2s")]
        public virtual Amad1 BusinessPartyCodeNavigation { get; set; } = null!;
    }
}
