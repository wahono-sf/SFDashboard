using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("impo2")]
    public partial class Impo2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        public int? PoLineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        public int? BalanceQty { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? ItemType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
        public int? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitPrice { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(24)]
        public string? VendorProductCode { get; set; }
        [StringLength(50)]
        public string? VendorUomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
    }
}
