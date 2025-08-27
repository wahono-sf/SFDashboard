using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcpb1
    {
        [Column("Nric No")]
        [StringLength(15)]
        public string NricNo { get; set; } = null!;
        [StringLength(45)]
        public string? Name { get; set; }
        [Column("Contact No")]
        [StringLength(30)]
        public string? ContactNo { get; set; }
        [Column("Vehicle No")]
        [StringLength(25)]
        public string? VehicleNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
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
