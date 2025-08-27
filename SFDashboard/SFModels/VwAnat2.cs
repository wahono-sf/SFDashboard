using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAnat2
    {
        [Column("Form No")]
        public int FormNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column("Awb Copy")]
        [StringLength(3)]
        public string? AwbCopy { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Column("Awb Status Code")]
        [StringLength(3)]
        public string? AwbStatusCode { get; set; }
        [Column("Awb Type")]
        [StringLength(1)]
        public string? AwbType { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
    }
}
