using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("ia_oh_inv")]
    public partial class IaOhInv
    {
        [Column("AFS_CHG", TypeName = "decimal(13, 2)")]
        public decimal? AfsChg { get; set; }
        [Column("BRK_AMT", TypeName = "decimal(13, 2)")]
        public decimal? BrkAmt { get; set; }
        [Column("CARTAGE_AMT", TypeName = "decimal(13, 2)")]
        public decimal? CartageAmt { get; set; }
        [Column("DOC_AMT", TypeName = "decimal(13, 2)")]
        public decimal? DocAmt { get; set; }
        [Column("FRT_AMT", TypeName = "decimal(13, 2)")]
        public decimal? FrtAmt { get; set; }
        [Column("MAWB_NO")]
        [StringLength(12)]
        public string? MawbNo { get; set; }
        [Column("HANDG_AMT", TypeName = "decimal(13, 2)")]
        public decimal? HandgAmt { get; set; }
        [Column("INV_NO")]
        [StringLength(8)]
        public string? InvNo { get; set; }
        [Column("ISS_CHG", TypeName = "decimal(13, 2)")]
        public decimal? IssChg { get; set; }
        [Column("ONHAND_NO")]
        [StringLength(8)]
        public string? OnhandNo { get; set; }
        [Column("OS_LOC_AMT", TypeName = "decimal(13, 2)")]
        public decimal? OsLocAmt { get; set; }
        [Column("OTHER_AMT", TypeName = "decimal(13, 2)")]
        public decimal? OtherAmt { get; set; }
        [Column("PO_NO")]
        [StringLength(35)]
        public string? PoNo { get; set; }
        [Column("PO_PROG_AMT", TypeName = "decimal(13, 2)")]
        public decimal? PoProgAmt { get; set; }
        [Column("SUB_MAWB")]
        [StringLength(12)]
        public string? SubMawb { get; set; }
        [Column("TRK_CHG_AMT", TypeName = "decimal(13, 2)")]
        public decimal? TrkChgAmt { get; set; }
    }
}
