using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSael1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Allow Skip Flag")]
        [StringLength(1)]
        public string? AllowSkipFlag { get; set; }
        [Column("Auto Flag")]
        [StringLength(1)]
        public string? AutoFlag { get; set; }
        [Column("Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTime { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("Email Count")]
        public int? EmailCount { get; set; }
        [Column("Event Code")]
        [StringLength(10)]
        public string? EventCode { get; set; }
        public int? LineItemNo { get; set; }
        [Column("Primary Key Name")]
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [Column("Primary Key Value")]
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(80)]
        public string? Remark { get; set; }
        [Column("Show eTrack Flag")]
        [StringLength(1)]
        public string? ShowETrackFlag { get; set; }
        [Column("Start Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? StartDateTime { get; set; }
        [Column("Table Name")]
        [StringLength(10)]
        public string? TableName { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(10)]
        public string? Status { get; set; }
    }
}
