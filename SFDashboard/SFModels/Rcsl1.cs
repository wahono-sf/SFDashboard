using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcsl1")]
    public partial class Rcsl1
    {
        public Rcsl1()
        {
            Ssst1s = new HashSet<Ssst1>();
        }

        [Key]
        [StringLength(12)]
        public string ShippinglineCode { get; set; } = null!;
        [StringLength(80)]
        public string? ShippinglineName { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(10)]
        public string? AnalysisCode { get; set; }
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? CommissionPercent { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(30)]
        public string? CrNo { get; set; }
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [Column("FIataCode")]
        [StringLength(14)]
        public string? FiataCode { get; set; }
        [StringLength(16)]
        public string? PrincipleAccCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? ShipAgentCode { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(10)]
        public string? Telex { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(50)]
        public string? VendorRequestBy { get; set; }
        [StringLength(50)]
        public string? WebSite { get; set; }
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

        [InverseProperty("ShippingLineCodeNavigation")]
        public virtual ICollection<Ssst1> Ssst1s { get; set; }
    }
}
