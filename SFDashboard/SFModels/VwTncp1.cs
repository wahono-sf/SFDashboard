using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTncp1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Product Code")]
        [StringLength(35)]
        public string? ProductCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Description 1")]
        [StringLength(4000)]
        public string? Description1 { get; set; }
        [Column("Description 2")]
        [StringLength(35)]
        public string? Description2 { get; set; }
        [Column("Description 3")]
        [StringLength(35)]
        public string? Description3 { get; set; }
        [Column("Description 4")]
        [StringLength(35)]
        public string? Description4 { get; set; }
        [Column("Description 5")]
        [StringLength(35)]
        public string? Description5 { get; set; }
        [Column("HS Code")]
        [StringLength(8)]
        public string? HsCode { get; set; }
        [Column("HS UOM Code")]
        [StringLength(3)]
        public string? HsUomCode { get; set; }
        [Column("Reference ID")]
        [StringLength(50)]
        public string? ReferenceId { get; set; }
        [Column("Unit Code")]
        [StringLength(3)]
        public string? UnitCode { get; set; }
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
