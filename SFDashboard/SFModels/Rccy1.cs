using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rccy1")]
    public partial class Rccy1
    {
        [Key]
        [StringLength(2)]
        public string CountryCode { get; set; } = null!;
        [StringLength(45)]
        public string? CountryName { get; set; }
        [Column(TypeName = "image")]
        public byte[]? FlagImage { get; set; }
        [StringLength(4000)]
        public string? HandlingInstruction { get; set; }
        [StringLength(4)]
        public string? Idd { get; set; }
        [StringLength(5)]
        public string? RegionCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(3000)]
        public string? SpecialInstruction { get; set; }
        [StringLength(5)]
        public string? ZoneCode { get; set; }
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
