using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcvs1
    {
        [Column("Vessel Code")]
        [StringLength(50)]
        public string VesselCode { get; set; } = null!;
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Grt { get; set; }
        [Column("Imo No")]
        [StringLength(7)]
        public string? ImoNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Nrt { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Ship Owner Code")]
        [StringLength(10)]
        public string? ShipOwnerCode { get; set; }
        [Column("Ship Owner Name")]
        [StringLength(45)]
        public string? ShipOwnerName { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Vessel Classification")]
        [StringLength(10)]
        public string? VesselClassification { get; set; }
        [Column("Vessel Short Name")]
        [StringLength(20)]
        public string? VesselShortName { get; set; }
        [Column("Vessel Type")]
        [StringLength(2)]
        public string? VesselType { get; set; }
        [Column("Year Build")]
        public short? YearBuild { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
