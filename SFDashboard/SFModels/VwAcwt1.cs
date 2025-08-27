using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAcwt1
    {
        [Column("With Hold Tax Code")]
        [StringLength(3)]
        public string WithHoldTaxCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Tax Description")]
        [StringLength(50)]
        public string? TaxDescription { get; set; }
        [Column("Tax Rate", TypeName = "decimal(9, 3)")]
        public decimal? TaxRate { get; set; }
        [Column("Vendor Type")]
        [StringLength(5)]
        public string? VendorType { get; set; }
        [Column("WHT Corporate AccCode")]
        [StringLength(15)]
        public string? WhtCorporateAccCode { get; set; }
        [Column("WHT Personal AccCode")]
        [StringLength(15)]
        public string? WhtPersonalAccCode { get; set; }
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
