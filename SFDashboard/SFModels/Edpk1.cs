using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("edpk1")]
    public partial class Edpk1
    {
        [Key]
        [StringLength(35)]
        public string CommercialInvoiceNo { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("CustomerID")]
        [StringLength(10)]
        public string? CustomerId { get; set; }
        [Column("DivisionID")]
        [StringLength(5)]
        public string? DivisionId { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? LooseQty { get; set; }
        [StringLength(3)]
        public string? LooseUomCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NetWeight { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? NumberOfPackage { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PackHeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PackLength { get; set; }
        [StringLength(3)]
        public string? PackUom { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PackWidth { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? SysFreightBookingOrJobNo { get; set; }
        [StringLength(13)]
        public string? SysFreightContainerNo { get; set; }
        [StringLength(2)]
        public string? SysFreightModuleCode { get; set; }
        [StringLength(30)]
        public string? SysFreightSealNo { get; set; }
        [StringLength(3)]
        public string? UomPackage { get; set; }
        [StringLength(3)]
        public string? UomVolume { get; set; }
        [StringLength(3)]
        public string? UomWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Volume { get; set; }
    }
}
