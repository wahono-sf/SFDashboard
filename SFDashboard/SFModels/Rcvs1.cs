using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcvs1")]
    public partial class Rcvs1
    {
        [Key]
        [StringLength(50)]
        public string VesselCode { get; set; } = null!;
        [StringLength(50)]
        public string? VesselName { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Grt { get; set; }
        [StringLength(7)]
        public string? ImoNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Nrt { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? ShipOwnerCode { get; set; }
        [StringLength(45)]
        public string? ShipOwnerName { get; set; }
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [StringLength(10)]
        public string? VesselClassification { get; set; }
        [StringLength(20)]
        public string? VesselShortName { get; set; }
        [StringLength(2)]
        public string? VesselType { get; set; }
        public short? YearBuild { get; set; }
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
