using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omtx7")]
    public partial class Omtx7
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string? InvoiceNo { get; set; }
        public int? LooseQty { get; set; }
        public int? OrderTrxNo { get; set; }
        public int? OrderLineItemNo { get; set; }
        public int? Pcs { get; set; }
        [StringLength(50)]
        public string? PoNo { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVol { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalWt { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
    }
}
