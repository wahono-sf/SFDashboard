using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slcm2")]
    public partial class Slcm2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(50)]
        public string? Branch { get; set; }
        [StringLength(80)]
        public string? Companyname { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(500)]
        public string? LicenceKey { get; set; }
        [StringLength(80)]
        public string? Module { get; set; }
        public int? NoOfUser { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(200)]
        public string? Version { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Slcm2s")]
        public virtual Slcm1 TrxNoNavigation { get; set; } = null!;
    }
}
