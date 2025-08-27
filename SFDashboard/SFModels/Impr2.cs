using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("impr2")]
    public partial class Impr2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? KitPartNo { get; set; }
        public int? KitPartNoTrxNo { get; set; }
        [StringLength(255)]
        public string? KitProductCode { get; set; }
        [StringLength(1)]
        public string? KitProductFlag { get; set; }
        public int? KitProductTrxNo { get; set; }
        public int? KitQty { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalUnitCost { get; set; }
        [StringLength(2)]
        public string? Origin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? QuoteDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UnitCost { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(24)]
        public string? VendorProductCode { get; set; }
    }
}
