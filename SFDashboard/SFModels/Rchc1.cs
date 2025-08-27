using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rchc1")]
    public partial class Rchc1
    {
        public Rchc1()
        {
            Amdc1s = new HashSet<Amdc1>();
            Amid2s = new HashSet<Amid2>();
            Amio2s = new HashSet<Amio2>();
        }

        [Key]
        [StringLength(3)]
        public string ChargeCode { get; set; } = null!;
        [StringLength(50)]
        public string? ChargeDescription { get; set; }
        [Column("AirlineID")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [StringLength(1)]
        public string? AwbFlag { get; set; }
        [StringLength(20)]
        public string? AwbPrintDescription { get; set; }
        [StringLength(1)]
        public string? ChargeUnit { get; set; }
        [StringLength(1)]
        public string? DueParty { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? Rate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
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

        [InverseProperty("AwbChargeCodeNavigation")]
        public virtual ICollection<Amdc1> Amdc1s { get; set; }
        [InverseProperty("AwbChargeCodeNavigation")]
        public virtual ICollection<Amid2> Amid2s { get; set; }
        [InverseProperty("AwbChargeCodeNavigation")]
        public virtual ICollection<Amio2> Amio2s { get; set; }
    }
}
