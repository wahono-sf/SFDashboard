using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcct1")]
    [Index("CityName", Name = "INDEX_Rcct1_CityName")]
    [Index("StatusCode", Name = "INDEX_Rcct1_StatusCode")]
    [Index("CityCode", Name = "IX_rcct1")]
    public partial class Rcct1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(3)]
        public string CityCode { get; set; } = null!;
        [StringLength(45)]
        public string? CityName { get; set; }
        [StringLength(2)]
        public string CountryCode { get; set; } = null!;
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(5)]
        public string? ViaPort { get; set; }
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
