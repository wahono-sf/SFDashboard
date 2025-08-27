using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAeaw2
    {
        [Column("Awb No")]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Box No", TypeName = "decimal(6, 0)")]
        public decimal? BoxNo { get; set; }
        [Column("Case Marking")]
        [StringLength(200)]
        public string? CaseMarking { get; set; }
        [Column("CCC")]
        [StringLength(50)]
        public string? Ccc { get; set; }
        [Column("Chg Wt Lb", TypeName = "decimal(13, 4)")]
        public decimal? ChgWtLb { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Dimension { get; set; }
        [Column("Gross Weight", TypeName = "decimal(11, 2)")]
        public decimal? GrossWeight { get; set; }
        [Column("Gross Wt Lb", TypeName = "decimal(13, 4)")]
        public decimal? GrossWtLb { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Length { get; set; }
        [Column("Loose Qty", TypeName = "decimal(10, 0)")]
        public decimal? LooseQty { get; set; }
        [Column("Loose Uom Code")]
        [StringLength(3)]
        public string? LooseUomCode { get; set; }
        [Column(TypeName = "decimal(22, 0)")]
        public decimal? Pcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Req Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReqDate { get; set; }
        [Column("Request No")]
        [StringLength(50)]
        public string? RequestNo { get; set; }
        [Column("Trucker Amt", TypeName = "decimal(11, 2)")]
        public decimal? TruckerAmt { get; set; }
        [Column("Vol Wt", TypeName = "decimal(11, 4)")]
        public decimal? VolWt { get; set; }
        [Column("Vol Wt Lb", TypeName = "decimal(12, 4)")]
        public decimal? VolWtLb { get; set; }
        [Column("Vote Charge")]
        [StringLength(50)]
        public string? VoteCharge { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Width { get; set; }
    }
}
