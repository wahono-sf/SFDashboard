using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmtx2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column("Balance Loose Qty")]
        public int? BalanceLooseQty { get; set; }
        [Column("Balance Packing Qty")]
        public int? BalancePackingQty { get; set; }
        [Column("Balance Volume", TypeName = "decimal(13, 4)")]
        public decimal? BalanceVolume { get; set; }
        [Column("Balance Weight", TypeName = "decimal(13, 4)")]
        public decimal? BalanceWeight { get; set; }
        [Column("Balance Whole Qty")]
        public int? BalanceWholeQty { get; set; }
        [Column("Batch No")]
        [StringLength(20)]
        public string? BatchNo { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Container No")]
        [StringLength(50)]
        public string? ContainerNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Damage Return Qty")]
        public int? DamageReturnQty { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Date { get; set; }
        [Column("Dimension Flag")]
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column("Invoice Line Item No")]
        public int? InvoiceLineItemNo { get; set; }
        [Column("Invoice No")]
        [StringLength(50)]
        public string? InvoiceNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Packing No")]
        [StringLength(25)]
        public string? PackingNo { get; set; }
        [Column("Packing No 1")]
        [StringLength(14)]
        public string? PackingNo1 { get; set; }
        [Column("Packing No 2")]
        [StringLength(14)]
        public string? PackingNo2 { get; set; }
        [Column("Packing No 3")]
        [StringLength(14)]
        public string? PackingNo3 { get; set; }
        [Column("Packing No 4")]
        [StringLength(14)]
        public string? PackingNo4 { get; set; }
        [Column("Packing No 5")]
        [StringLength(14)]
        public string? PackingNo5 { get; set; }
        [Column("Packing No 6")]
        [StringLength(14)]
        public string? PackingNo6 { get; set; }
        [Column("Packing No 7")]
        [StringLength(14)]
        public string? PackingNo7 { get; set; }
        [Column("Packing No 8")]
        [StringLength(14)]
        public string? PackingNo8 { get; set; }
        [Column("Packing No 9")]
        [StringLength(14)]
        public string? PackingNo9 { get; set; }
        [Column("Packing No 10")]
        [StringLength(14)]
        public string? PackingNo10 { get; set; }
        [Column("Packing No 11")]
        [StringLength(14)]
        public string? PackingNo11 { get; set; }
        [Column("Packing No 12")]
        [StringLength(14)]
        public string? PackingNo12 { get; set; }
        [Column("Packing No 13")]
        [StringLength(14)]
        public string? PackingNo13 { get; set; }
        [Column("Packing No 14")]
        [StringLength(14)]
        public string? PackingNo14 { get; set; }
        [Column("Packing No 15")]
        [StringLength(14)]
        public string? PackingNo15 { get; set; }
        [Column("Packing Qty")]
        public int? PackingQty { get; set; }
        [Column("Packing Size")]
        public int? PackingSize { get; set; }
        [Column("Pallet ID")]
        [StringLength(50)]
        public string? PalletId { get; set; }
        public int? Pcs { get; set; }
        [Column("Po Line Item No")]
        public int? PoLineItemNo { get; set; }
        [Column("Po No")]
        [StringLength(50)]
        public string? PoNo { get; set; }
        [Column("Product Code")]
        [StringLength(50)]
        public string? ProductCode { get; set; }
        [Column("Product Description")]
        [StringLength(255)]
        public string? ProductDescription { get; set; }
        [Column("Put Away Flag")]
        [StringLength(1)]
        public string? PutAwayFlag { get; set; }
        [Column("Put Away Group")]
        public int? PutAwayGroup { get; set; }
        [Column("Qc Qty")]
        public int? QcQty { get; set; }
        [Column("Qty 1")]
        public int? Qty1 { get; set; }
        [Column("Qty 2")]
        public int? Qty2 { get; set; }
        [Column("Qty 3")]
        public int? Qty3 { get; set; }
        [Column("Qty 4")]
        public int? Qty4 { get; set; }
        [Column("Qty 5")]
        public int? Qty5 { get; set; }
        [Column("Qty 6")]
        public int? Qty6 { get; set; }
        [Column("Qty 7")]
        public int? Qty7 { get; set; }
        [Column("Qty 8")]
        public int? Qty8 { get; set; }
        [Column("Qty 9")]
        public int? Qty9 { get; set; }
        [Column("Qty 10")]
        public int? Qty10 { get; set; }
        [Column("Qty 11")]
        public int? Qty11 { get; set; }
        [Column("Qty 12")]
        public int? Qty12 { get; set; }
        [Column("Qty 13")]
        public int? Qty13 { get; set; }
        [Column("Qty 14")]
        public int? Qty14 { get; set; }
        [Column("Qty 15")]
        public int? Qty15 { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Seq No")]
        public long SeqNo { get; set; }
        [Column("Total Vol", TypeName = "decimal(13, 4)")]
        public decimal? TotalVol { get; set; }
        [Column("Total Wt", TypeName = "decimal(13, 4)")]
        public decimal? TotalWt { get; set; }
        [Column("Unit Vol", TypeName = "decimal(13, 4)")]
        public decimal? UnitVol { get; set; }
        [Column("Unit Wt", TypeName = "decimal(13, 4)")]
        public decimal? UnitWt { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
