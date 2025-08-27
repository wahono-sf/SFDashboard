using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImlt2
    {
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Business Party Code")]
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Lot No")]
        [StringLength(20)]
        public string LotNo { get; set; } = null!;
        [Column("Permit No")]
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [Column("Product Code")]
        [StringLength(24)]
        public string? ProductCode { get; set; }
        [Column("Receive Note Or Issue Note No")]
        [StringLength(20)]
        public string? ReceiveNoteOrIssueNoteNo { get; set; }
        [Column("Receive Or Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiveOrIssueDate { get; set; }
        [Column("Receive Or Issue Trx No")]
        public int? ReceiveOrIssueTrxNo { get; set; }
        [Column("Space Area", TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
    }
}
