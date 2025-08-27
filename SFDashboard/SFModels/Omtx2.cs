using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omtx2")]
    public partial class Omtx2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        public int? BalanceLooseQty { get; set; }
        public int? BalancePackingQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BalanceVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BalanceWeight { get; set; }
        public int? BalanceWholeQty { get; set; }
        [StringLength(20)]
        public string? BatchNo { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(50)]
        public string? ContainerNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        public int? DamageReturnQty { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        public int? InvoiceLineItemNo { get; set; }
        [StringLength(50)]
        public string? InvoiceNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        public int? LooseQty { get; set; }
        [StringLength(25)]
        public string? PackingNo { get; set; }
        [StringLength(14)]
        public string? PackingNo1 { get; set; }
        [StringLength(14)]
        public string? PackingNo2 { get; set; }
        [StringLength(14)]
        public string? PackingNo3 { get; set; }
        [StringLength(14)]
        public string? PackingNo4 { get; set; }
        [StringLength(14)]
        public string? PackingNo5 { get; set; }
        [StringLength(14)]
        public string? PackingNo6 { get; set; }
        [StringLength(14)]
        public string? PackingNo7 { get; set; }
        [StringLength(14)]
        public string? PackingNo8 { get; set; }
        [StringLength(14)]
        public string? PackingNo9 { get; set; }
        [StringLength(14)]
        public string? PackingNo10 { get; set; }
        [StringLength(14)]
        public string? PackingNo11 { get; set; }
        [StringLength(14)]
        public string? PackingNo12 { get; set; }
        [StringLength(14)]
        public string? PackingNo13 { get; set; }
        [StringLength(14)]
        public string? PackingNo14 { get; set; }
        [StringLength(14)]
        public string? PackingNo15 { get; set; }
        public int? PackingQty { get; set; }
        public int? PackingSize { get; set; }
        [Column("PalletID")]
        [StringLength(50)]
        public string? PalletId { get; set; }
        public int? Pcs { get; set; }
        public int? PoLineItemNo { get; set; }
        [StringLength(50)]
        public string? PoNo { get; set; }
        [StringLength(24)]
        public string? ProductCode { get; set; }
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        [StringLength(1)]
        public string? PutAwayFlag { get; set; }
        public int? PutAwayGroup { get; set; }
        public int? QcQty { get; set; }
        public int? Qty1 { get; set; }
        public int? Qty2 { get; set; }
        public int? Qty3 { get; set; }
        public int? Qty4 { get; set; }
        public int? Qty5 { get; set; }
        public int? Qty6 { get; set; }
        public int? Qty7 { get; set; }
        public int? Qty8 { get; set; }
        public int? Qty9 { get; set; }
        public int? Qty10 { get; set; }
        public int? Qty11 { get; set; }
        public int? Qty12 { get; set; }
        public int? Qty13 { get; set; }
        public int? Qty14 { get; set; }
        public int? Qty15 { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        public long SeqNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVol { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalWt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitVol { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitWt { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        public int? WholeQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Omtx2s")]
        public virtual Omtx1 TrxNoNavigation { get; set; } = null!;
    }
}
