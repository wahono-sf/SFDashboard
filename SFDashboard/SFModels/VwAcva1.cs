using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAcva1
    {
        [Column("Vat Code")]
        [StringLength(3)]
        public string VatCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Invlusive Flag")]
        [StringLength(1)]
        public string? InvlusiveFlag { get; set; }
        [Column("In Vat Acc Code")]
        [StringLength(15)]
        public string? InVatAccCode { get; set; }
        [Column("Out Vat Acc Code")]
        [StringLength(15)]
        public string? OutVatAccCode { get; set; }
        [Column("Paid In Vat Acc Code")]
        [StringLength(15)]
        public string? PaidInVatAccCode { get; set; }
        [Column("Paid Out Vat Acc Code")]
        [StringLength(15)]
        public string? PaidOutVatAccCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Cost Flag")]
        [StringLength(1)]
        public string? SalesCostFlag { get; set; }
        [Column("Vat Description")]
        [StringLength(50)]
        public string? VatDescription { get; set; }
        [Column("Vat Rate", TypeName = "decimal(6, 3)")]
        public decimal? VatRate { get; set; }
        [Column("Vat Type")]
        [StringLength(3)]
        public string? VatType { get; set; }
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
