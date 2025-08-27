using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("impv2")]
    public partial class Impv2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(11)]
        public string? GoodReceiptNoteOrGoodIssueNoteNo { get; set; }
        public int? LooseQty { get; set; }
        [StringLength(20)]
        public string? LotNo { get; set; }
        public int? PartNoTrxNo { get; set; }
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [StringLength(24)]
        public string? ProductCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptOrIssueDate { get; set; }
        public int? ReceiptOrIssueTrxNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
    }
}
