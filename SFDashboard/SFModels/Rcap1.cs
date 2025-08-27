using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcap1")]
    public partial class Rcap1
    {
        public Rcap1()
        {
            Amac1DestCodeNavigations = new HashSet<Amac1>();
            Amac1OriginCodeNavigations = new HashSet<Amac1>();
            Amif1DestCodeNavigations = new HashSet<Amif1>();
            Amif1OriginCodeNavigations = new HashSet<Amif1>();
            Ssst1PortOfDischargeCodeNavigations = new HashSet<Ssst1>();
            Ssst1PortOfLoadingCodeNavigations = new HashSet<Ssst1>();
        }

        [Key]
        [StringLength(3)]
        public string AirportCode { get; set; } = null!;
        [StringLength(45)]
        public string? AirportName { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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

        [InverseProperty("DestCodeNavigation")]
        public virtual ICollection<Amac1> Amac1DestCodeNavigations { get; set; }
        [InverseProperty("OriginCodeNavigation")]
        public virtual ICollection<Amac1> Amac1OriginCodeNavigations { get; set; }
        [InverseProperty("DestCodeNavigation")]
        public virtual ICollection<Amif1> Amif1DestCodeNavigations { get; set; }
        [InverseProperty("OriginCodeNavigation")]
        public virtual ICollection<Amif1> Amif1OriginCodeNavigations { get; set; }
        [InverseProperty("PortOfDischargeCodeNavigation")]
        public virtual ICollection<Ssst1> Ssst1PortOfDischargeCodeNavigations { get; set; }
        [InverseProperty("PortOfLoadingCodeNavigation")]
        public virtual ICollection<Ssst1> Ssst1PortOfLoadingCodeNavigations { get; set; }
    }
}
