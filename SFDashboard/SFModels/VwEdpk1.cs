using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwEdpk1
    {
        [Column("Commercial Invoice No")]
        [StringLength(35)]
        public string CommercialInvoiceNo { get; set; } = null!;
        [Column("Customer ID")]
        [StringLength(10)]
        public string? CustomerId { get; set; }
        [Column("Division ID")]
        [StringLength(5)]
        public string? DivisionId { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Commodity DescrIption")]
        [StringLength(50)]
        public string? CommodityDescrIption { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 2)")]
        public decimal? GrossWeight { get; set; }
        [Column("Loose Qty", TypeName = "decimal(10, 0)")]
        public decimal? LooseQty { get; set; }
        [Column("Loose Uom Code")]
        [StringLength(50)]
        public string? LooseUomCode { get; set; }
        [Column("Net Weight", TypeName = "decimal(13, 2)")]
        public decimal? NetWeight { get; set; }
        [Column("Number Of Package", TypeName = "decimal(10, 0)")]
        public decimal? NumberOfPackage { get; set; }
        [Column("Pack Height", TypeName = "decimal(13, 2)")]
        public decimal? PackHeight { get; set; }
        [Column("Pack Length", TypeName = "decimal(13, 2)")]
        public decimal? PackLength { get; set; }
        [Column("Pack UOM")]
        [StringLength(3)]
        public string? PackUom { get; set; }
        [Column("Pack Width", TypeName = "decimal(13, 2)")]
        public decimal? PackWidth { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [Column("SysFreight Booking Or Job No")]
        [StringLength(30)]
        public string? SysFreightBookingOrJobNo { get; set; }
        [Column("SysFreight Container No")]
        [StringLength(13)]
        public string? SysFreightContainerNo { get; set; }
        [Column("SysFreight Module Code")]
        [StringLength(2)]
        public string? SysFreightModuleCode { get; set; }
        [Column("SysFreight Seal No")]
        [StringLength(30)]
        public string? SysFreightSealNo { get; set; }
        [Column("UOM Package")]
        [StringLength(3)]
        public string? UomPackage { get; set; }
        [Column("UOM Volume")]
        [StringLength(3)]
        public string? UomVolume { get; set; }
        [Column("UOM Weight")]
        [StringLength(3)]
        public string? UomWeight { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? Volume { get; set; }
    }
}
