using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sicp2")]
    public partial class Sicp2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [StringLength(30)]
        public string? CostItemCode { get; set; }
        [StringLength(50)]
        public string? CostItemDescription { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ForeignAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(1)]
        public string? PostToApFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
    }
}
