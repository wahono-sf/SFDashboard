using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omor1")]
    public partial class Omor1
    {
        [Key]
        [StringLength(16)]
        public string ContrNo { get; set; } = null!;
        [StringLength(14)]
        public string? AmendNo { get; set; }
        [StringLength(1)]
        public string? AmendTermCode { get; set; }
        [StringLength(14)]
        public string? ContrVarNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateAdded { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateChanged { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateContrEff { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateContrSign { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastRecv { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(4)]
        public string? DocType { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? FmsAdminChg { get; set; }
        [StringLength(16)]
        public string? FmsCaseNo { get; set; }
        [StringLength(14)]
        public string? FmsContrNo { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? FmsEstNetChg { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? FmsEstTotalChg { get; set; }
        [StringLength(6)]
        public string? FmsFrtForwCode { get; set; }
        [StringLength(6)]
        public string? FmsMarkCode { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? FmsOtherCost { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? FmsPackCratHandg { get; set; }
        [StringLength(1)]
        public string? FmsProcuAgtCode { get; set; }
        [StringLength(1)]
        public string? FmsSalesTerm { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? FmsTransportCost { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? QtyRecv { get; set; }
        [StringLength(2)]
        public string? RecStatus { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? SdFlag { get; set; }
        [StringLength(12)]
        public string? SupplierCode { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? TotalAmtL { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
