using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rctl1")]
    public partial class Rctl1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string TerminalCode { get; set; } = null!;
        [StringLength(50)]
        public string? TerminalName { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(50)]
        public string? ContactInfo { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(20)]
        public string? PaperlessCode { get; set; }
        [StringLength(5)]
        public string? PortCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
