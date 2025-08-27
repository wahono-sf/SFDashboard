using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSebl4
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Cargo Line Item No")]
        public short CargoLineItemNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Booking No", TypeName = "decimal(18, 0)")]
        public decimal? BookingNo { get; set; }
        [Column("Box No", TypeName = "decimal(6, 0)")]
        public decimal? BoxNo { get; set; }
        [Column("Case Marking")]
        [StringLength(200)]
        public string? CaseMarking { get; set; }
        [Column("CCC")]
        [StringLength(50)]
        public string? Ccc { get; set; }
        [Column("Chg Wt Lbs", TypeName = "decimal(13, 2)")]
        public decimal? ChgWtLbs { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Gross Wt Lbs", TypeName = "decimal(12, 3)")]
        public decimal? GrossWtLbs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column("Ind Trk Amt", TypeName = "decimal(12, 3)")]
        public decimal? IndTrkAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column("Loose Qty", TypeName = "decimal(10, 0)")]
        public decimal? LooseQty { get; set; }
        [Column("Loose Uom Code")]
        [StringLength(3)]
        public string? LooseUomCode { get; set; }
        public int? Pcs { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
        [Column("Req Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReqDate { get; set; }
        [Column("Request No")]
        [StringLength(50)]
        public string? RequestNo { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Vol Wt Lbs", TypeName = "decimal(12, 3)")]
        public decimal? VolWtLbs { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(50)]
        public string? Vote { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
