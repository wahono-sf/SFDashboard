using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbp4
    {
        [Column("Business Party Code")]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Competitor Code")]
        [StringLength(10)]
        public string? CompetitorCode { get; set; }
        [Column("Competitor Name")]
        [StringLength(80)]
        public string? CompetitorName { get; set; }
        [Column("DEst Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
