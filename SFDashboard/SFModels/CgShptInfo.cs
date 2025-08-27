using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("CG_SHPT_INFO")]
    public partial class CgShptInfo
    {
        [Column("AMTPAID", TypeName = "decimal(12, 2)")]
        public decimal? Amtpaid { get; set; }
        [Column("DATEAPPROVED", TypeName = "datetime")]
        public DateTime? Dateapproved { get; set; }
        [Column("DATEDECLR", TypeName = "datetime")]
        public DateTime? Datedeclr { get; set; }
        [Column("DECLRTYPE")]
        [StringLength(12)]
        public string? Declrtype { get; set; }
        [Column("GSTCOMPUTED")]
        [StringLength(10)]
        public string? Gstcomputed { get; set; }
        [Column("GSTTYPE")]
        [StringLength(10)]
        public string? Gsttype { get; set; }
        [Column("HAWBHBL")]
        [StringLength(12)]
        public string? Hawbhbl { get; set; }
        [Column("MAWBOBL")]
        [StringLength(12)]
        public string? Mawbobl { get; set; }
        [Column("MSGREFNO")]
        [StringLength(12)]
        public string? Msgrefno { get; set; }
        [Column("MSGTYPE")]
        [StringLength(10)]
        public string? Msgtype { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? NoofPcs { get; set; }
        [StringLength(12)]
        public string? PermitNo { get; set; }
        [Column("TRDCRNO")]
        [StringLength(12)]
        public string? Trdcrno { get; set; }
        [Column("TOTWTDECLR", TypeName = "decimal(10, 2)")]
        public decimal? Totwtdeclr { get; set; }
        [Column("TOTVAL", TypeName = "decimal(12, 2)")]
        public decimal? Totval { get; set; }
        [Column("TOTDUTY", TypeName = "decimal(12, 2)")]
        public decimal? Totduty { get; set; }
        [Column("WTDECLRUNIT", TypeName = "decimal(12, 2)")]
        public decimal? Wtdeclrunit { get; set; }
    }
}
