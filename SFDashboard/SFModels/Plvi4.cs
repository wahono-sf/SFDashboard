using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plvi4")]
    public partial class Plvi4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? SourceRefNo { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(1)]
        public string? TaxFlag { get; set; }
        [Column("WHTAccCode")]
        [StringLength(15)]
        public string? WhtaccCode { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? WithHoldingBaseAmt { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? WithHoldingTaxAmt { get; set; }
        [StringLength(15)]
        public string? WithHoldingTaxCode { get; set; }
        [StringLength(255)]
        public string? WithHoldingTaxDesc { get; set; }
        [StringLength(20)]
        public string? WithHoldingTaxNo { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? WithHoldingTaxRate { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? DeleteBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteDateTime { get; set; }
    }
}
