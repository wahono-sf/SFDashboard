using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAmad2
    {
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Business Party Code")]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Column("Awb Charge Code")]
        [StringLength(3)]
        public string? AwbChargeCode { get; set; }
        [Column("Charge Type")]
        [StringLength(1)]
        public string? ChargeType { get; set; }
        [Column("Quote Amt", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt { get; set; }
        [Column("Quote Rate 01", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate01 { get; set; }
        [Column("Quote Rate 02", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate02 { get; set; }
        [Column("Quote Rate 03", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate03 { get; set; }
        [Column("Quote Rate 04", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate04 { get; set; }
        [Column("Quote Rate 05", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate05 { get; set; }
        [Column("Quote Rate 06", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate06 { get; set; }
        [Column("Quote Rate 07", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate07 { get; set; }
        [Column("Quote Rate 08", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate08 { get; set; }
        [Column("Quote Rate 09", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate09 { get; set; }
        [Column("Quote Rate 10", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate10 { get; set; }
        [Column("Quote Rate 11", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate11 { get; set; }
        [Column("Quote Rate 12", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate12 { get; set; }
        [Column("Quote Rate 13", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate13 { get; set; }
        [Column("Quote Rate 14", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate14 { get; set; }
        [Column("Quote Rate 15", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate15 { get; set; }
        [Column("Quote Rate 16", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate16 { get; set; }
        [Column("Sales Item Code")]
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column("Weight 01", TypeName = "decimal(13, 4)")]
        public decimal? Weight01 { get; set; }
        [Column("Weight 02", TypeName = "decimal(13, 4)")]
        public decimal? Weight02 { get; set; }
        [Column("Weight 03", TypeName = "decimal(13, 4)")]
        public decimal? Weight03 { get; set; }
        [Column("Weight 04", TypeName = "decimal(13, 4)")]
        public decimal? Weight04 { get; set; }
        [Column("Weight 05", TypeName = "decimal(13, 4)")]
        public decimal? Weight05 { get; set; }
        [Column("Weight 06", TypeName = "decimal(13, 4)")]
        public decimal? Weight06 { get; set; }
        [Column("Weight 07", TypeName = "decimal(13, 4)")]
        public decimal? Weight07 { get; set; }
        [Column("Weight 08", TypeName = "decimal(13, 4)")]
        public decimal? Weight08 { get; set; }
        [Column("Weight 09", TypeName = "decimal(13, 4)")]
        public decimal? Weight09 { get; set; }
        [Column("Weight 10", TypeName = "decimal(13, 4)")]
        public decimal? Weight10 { get; set; }
        [Column("Weight 11", TypeName = "decimal(13, 4)")]
        public decimal? Weight11 { get; set; }
        [Column("Weight 12", TypeName = "decimal(13, 4)")]
        public decimal? Weight12 { get; set; }
        [Column("Weight 13", TypeName = "decimal(13, 4)")]
        public decimal? Weight13 { get; set; }
        [Column("Weight 14", TypeName = "decimal(13, 4)")]
        public decimal? Weight14 { get; set; }
        [Column("Weight 15", TypeName = "decimal(13, 4)")]
        public decimal? Weight15 { get; set; }
        [Column("Weight 16", TypeName = "decimal(13, 4)")]
        public decimal? Weight16 { get; set; }
        [Column("Weight Type")]
        [StringLength(1)]
        public string? WeightType { get; set; }
    }
}
