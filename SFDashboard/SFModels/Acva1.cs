using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("acva1")]
    public partial class Acva1
    {
        public Acva1()
        {
            Ivch2s = new HashSet<Ivch2>();
            Ivcr2s = new HashSet<Ivcr2>();
            Omtx6s = new HashSet<Omtx6>();
            Sebk3s = new HashSet<Sebk3>();
        }

        [Key]
        [StringLength(10)]
        public string VatCode { get; set; } = null!;
        [StringLength(50)]
        public string? VatDescription { get; set; }
        [StringLength(1)]
        public string? InclusiveFlag { get; set; }
        [StringLength(15)]
        public string? InVatAccCode { get; set; }
        [StringLength(15)]
        public string? OutVatAccCode { get; set; }
        [StringLength(15)]
        public string? PaidInVatAccCode { get; set; }
        [StringLength(15)]
        public string? PaidOutVatAccCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? SalesCostFlag { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? VatRate { get; set; }
        [StringLength(3)]
        public string? VatType { get; set; }
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

        [InverseProperty("VatCodeNavigation")]
        public virtual ICollection<Ivch2> Ivch2s { get; set; }
        [InverseProperty("VatCodeNavigation")]
        public virtual ICollection<Ivcr2> Ivcr2s { get; set; }
        [InverseProperty("VatCodeNavigation")]
        public virtual ICollection<Omtx6> Omtx6s { get; set; }
        [InverseProperty("VatCodeNavigation")]
        public virtual ICollection<Sebk3> Sebk3s { get; set; }
    }
}
