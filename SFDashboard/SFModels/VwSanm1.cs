using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSanm1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? Cycle { get; set; }
        [Column("Date Type")]
        [StringLength(3)]
        public string? DateType { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("End No")]
        [StringLength(10)]
        public string? EndNo { get; set; }
        [Column("Inv Type")]
        [StringLength(50)]
        public string? InvType { get; set; }
        [Column("Job Type")]
        [StringLength(500)]
        public string? JobType { get; set; }
        [Column("Next No")]
        [StringLength(10)]
        public string? NextNo { get; set; }
        [Column("Number Type")]
        [StringLength(10)]
        public string? NumberType { get; set; }
        [StringLength(50)]
        public string? Prefix { get; set; }
        [Column("Prompt Next No")]
        [StringLength(10)]
        public string? PromptNextNo { get; set; }
        [Column("Shipment Type")]
        [StringLength(5)]
        public string? ShipmentType { get; set; }
        [StringLength(50)]
        public string? Suffix { get; set; }
        [Column("Trx Type")]
        [StringLength(50)]
        public string? TrxType { get; set; }
        [Column("User Group")]
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [Column("Vat Code")]
        [StringLength(20)]
        public string? VatCode { get; set; }
        [Column("Voucher Type")]
        [StringLength(50)]
        public string? VoucherType { get; set; }
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
    }
}
