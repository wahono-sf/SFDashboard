using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("acwt1")]
    public partial class Acwt1
    {
        [Key]
        [Column("WHoldTaxCode")]
        [StringLength(3)]
        public string WholdTaxCode { get; set; } = null!;
        [StringLength(50)]
        public string? TaxDescription { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? TaxRate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(5)]
        public string? VendorType { get; set; }
        [Column("WHTCorporateAccCode")]
        [StringLength(15)]
        public string? WhtcorporateAccCode { get; set; }
        [Column("WHTPersonalAccCode")]
        [StringLength(15)]
        public string? WhtpersonalAccCode { get; set; }
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
