using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSicp2
    {
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Cost Item Code")]
        [StringLength(30)]
        public string? CostItemCode { get; set; }
        [Column("Cost Item Description")]
        [StringLength(50)]
        public string? CostItemDescription { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Foreign Amt", TypeName = "decimal(13, 2)")]
        public decimal? ForeignAmt { get; set; }
        [Column("Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Post To Ap Flag")]
        [StringLength(1)]
        public string? PostToApFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Unit Rate", TypeName = "decimal(13, 3)")]
        public decimal? UnitRate { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
    }
}
