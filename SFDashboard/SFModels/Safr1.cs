using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("safr1")]
    public partial class Safr1
    {
        [Key]
        [StringLength(10)]
        public string FreightCompanyCode { get; set; } = null!;
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(1)]
        public string? CompanyStatus { get; set; }
        [StringLength(50)]
        public string? ContactName1 { get; set; }
        [StringLength(50)]
        public string? ContactName2 { get; set; }
        [StringLength(50)]
        public string? ContactName3 { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(50)]
        public string? Email1 { get; set; }
        [StringLength(50)]
        public string? Email2 { get; set; }
        [StringLength(50)]
        public string? Email3 { get; set; }
        [StringLength(30)]
        public string? Fax1 { get; set; }
        [StringLength(30)]
        public string? Fax2 { get; set; }
        [StringLength(30)]
        public string? Fax3 { get; set; }
        [StringLength(80)]
        public string? FreightCompanyName { get; set; }
        [StringLength(30)]
        public string? Handphone1 { get; set; }
        [StringLength(30)]
        public string? Handphone2 { get; set; }
        [StringLength(30)]
        public string? Handphone3 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(255)]
        public string? Services { get; set; }
        [StringLength(30)]
        public string? Telephone1 { get; set; }
        [StringLength(30)]
        public string? Telephone2 { get; set; }
        [StringLength(30)]
        public string? Telephone3 { get; set; }
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
    }
}
