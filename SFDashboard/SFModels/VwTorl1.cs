using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTorl1
    {
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("City Name")]
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("District Code")]
        [StringLength(10)]
        public string? DistrictCode { get; set; }
        [Column("Release Code")]
        [StringLength(10)]
        public string ReleaseCode { get; set; } = null!;
        [Column("Release Name 1")]
        [StringLength(50)]
        public string? ReleaseName1 { get; set; }
        [Column("Release Name 2")]
        [StringLength(50)]
        public string? ReleaseName2 { get; set; }
        [Column("Release Address 1")]
        [StringLength(45)]
        public string? ReleaseAddress1 { get; set; }
        [Column("Release Address 2")]
        [StringLength(45)]
        public string? ReleaseAddress2 { get; set; }
        [Column("Release Address 3")]
        [StringLength(45)]
        public string? ReleaseAddress3 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Zone Code")]
        [StringLength(5)]
        public string? ZoneCode { get; set; }
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
