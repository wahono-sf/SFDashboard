using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcsp1
    {
        [Column("Port Code")]
        [StringLength(5)]
        public string PortCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Combine Free Day")]
        public int? CombineFreeDay { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Demurrage Free Day")]
        public int? DemurrageFreeDay { get; set; }
        [Column("Detention Free Day")]
        public int? DetentionFreeDay { get; set; }
        [Column("DG Cargo Flag")]
        [StringLength(1)]
        public string? DgCargoFlag { get; set; }
        [Column("Group Code")]
        [StringLength(50)]
        public string? GroupCode { get; set; }
        [Column("Port Name")]
        [StringLength(45)]
        public string? PortName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Country Name")]
        [StringLength(45)]
        public string? CountryName { get; set; }
        [Column("IDD")]
        [StringLength(4)]
        public string? Idd { get; set; }
        [Column("Region Code")]
        [StringLength(5)]
        public string? RegionCode { get; set; }
        [StringLength(10)]
        public string? Symbol { get; set; }
        [Column("Via Port")]
        [StringLength(5)]
        public string? ViaPort { get; set; }
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
