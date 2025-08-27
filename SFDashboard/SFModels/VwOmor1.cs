using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmor1
    {
        [Column("Contr No")]
        [StringLength(16)]
        public string ContrNo { get; set; } = null!;
        [Column("Amend No")]
        [StringLength(14)]
        public string? AmendNo { get; set; }
        [Column("Amend Term Code")]
        [StringLength(1)]
        public string? AmendTermCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Contr Var No")]
        [StringLength(14)]
        public string? ContrVarNo { get; set; }
        [Column("Date Added")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateAdded { get; set; }
        [Column("Date Changed")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateChanged { get; set; }
        [Column("Date Contr Eff")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateContrEff { get; set; }
        [Column("Date Contr Sign")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateContrSign { get; set; }
        [Column("Date Last Recv")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateLastRecv { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Doc Type")]
        [StringLength(4)]
        public string? DocType { get; set; }
        [Column("Fms Admin Chg", TypeName = "decimal(16, 4)")]
        public decimal? FmsAdminChg { get; set; }
        [Column("Fms Case No")]
        [StringLength(16)]
        public string? FmsCaseNo { get; set; }
        [Column("Fms Contr No")]
        [StringLength(14)]
        public string? FmsContrNo { get; set; }
        [Column("Fms Est Net Chg", TypeName = "decimal(16, 4)")]
        public decimal? FmsEstNetChg { get; set; }
        [Column("Fms Est Total Chg", TypeName = "decimal(16, 4)")]
        public decimal? FmsEstTotalChg { get; set; }
        [Column("Fms Frt Forw Code")]
        [StringLength(6)]
        public string? FmsFrtForwCode { get; set; }
        [Column("Fms Mark Code")]
        [StringLength(6)]
        public string? FmsMarkCode { get; set; }
        [Column("Fms Other Cost", TypeName = "decimal(16, 4)")]
        public decimal? FmsOtherCost { get; set; }
        [Column("Fms Pack Crat handg", TypeName = "decimal(16, 4)")]
        public decimal? FmsPackCratHandg { get; set; }
        [Column("Fms Procu Agt Code")]
        [StringLength(1)]
        public string? FmsProcuAgtCode { get; set; }
        [Column("Fms Sales Term")]
        [StringLength(1)]
        public string? FmsSalesTerm { get; set; }
        [Column("Fms Transport Cost", TypeName = "decimal(16, 4)")]
        public decimal? FmsTransportCost { get; set; }
        [Column("Qty Recv", TypeName = "decimal(16, 4)")]
        public decimal? QtyRecv { get; set; }
        [Column("Rec Status")]
        [StringLength(2)]
        public string? RecStatus { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sd Flag")]
        [StringLength(1)]
        public string? SdFlag { get; set; }
        [Column("Supplier Code")]
        [StringLength(12)]
        public string? SupplierCode { get; set; }
        [Column("Total Amt L", TypeName = "decimal(16, 4)")]
        public decimal? TotalAmtL { get; set; }
    }
}
