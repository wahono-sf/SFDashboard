using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSafr1
    {
        [Column("Freight Company Code")]
        [StringLength(10)]
        public string FreightCompanyCode { get; set; } = null!;
        [Column("Address 1")]
        [StringLength(45)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(45)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(45)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(45)]
        public string? Address4 { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("Company Status")]
        [StringLength(1)]
        public string? CompanyStatus { get; set; }
        [Column("Contact Name 1")]
        [StringLength(50)]
        public string? ContactName1 { get; set; }
        [Column("Contact Name 2")]
        [StringLength(50)]
        public string? ContactName2 { get; set; }
        [Column("Contact Name 3")]
        [StringLength(50)]
        public string? ContactName3 { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Email 1")]
        [StringLength(50)]
        public string? Email1 { get; set; }
        [Column("Email 2")]
        [StringLength(50)]
        public string? Email2 { get; set; }
        [Column("Email 3")]
        [StringLength(50)]
        public string? Email3 { get; set; }
        [Column("Fax 1")]
        [StringLength(30)]
        public string? Fax1 { get; set; }
        [Column("Fax 2")]
        [StringLength(30)]
        public string? Fax2 { get; set; }
        [Column("Fax 3")]
        [StringLength(30)]
        public string? Fax3 { get; set; }
        [Column("Freight Company Name")]
        [StringLength(80)]
        public string? FreightCompanyName { get; set; }
        [Column("Handphone 1")]
        [StringLength(30)]
        public string? Handphone1 { get; set; }
        [Column("Handphone 2")]
        [StringLength(30)]
        public string? Handphone2 { get; set; }
        [Column("Handphone 3")]
        [StringLength(30)]
        public string? Handphone3 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(255)]
        public string? Services { get; set; }
        [Column("Telephone 1")]
        [StringLength(30)]
        public string? Telephone1 { get; set; }
        [Column("Telephone 2")]
        [StringLength(30)]
        public string? Telephone2 { get; set; }
        [Column("Telephone 3")]
        [StringLength(30)]
        public string? Telephone3 { get; set; }
        [Column("Web Site")]
        [StringLength(50)]
        public string? WebSite { get; set; }
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
