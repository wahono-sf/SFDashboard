using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSapb1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Birthday { get; set; }
        [Column("Children Name")]
        [StringLength(50)]
        public string? ChildrenName { get; set; }
        [Column("Company Address")]
        [StringLength(50)]
        public string? CompanyAddress { get; set; }
        [Column("Company Address 1")]
        [StringLength(50)]
        public string? CompanyAddress1 { get; set; }
        [Column("Company Address 2")]
        [StringLength(50)]
        public string? CompanyAddress2 { get; set; }
        [Column("Company Address 3")]
        [StringLength(50)]
        public string? CompanyAddress3 { get; set; }
        [Column("Company Address 4")]
        [StringLength(50)]
        public string? CompanyAddress4 { get; set; }
        [Column("Company City")]
        [StringLength(3)]
        public string? CompanyCity { get; set; }
        [Column("Company Country")]
        [StringLength(2)]
        public string? CompanyCountry { get; set; }
        [Column("Company Email")]
        [StringLength(50)]
        public string? CompanyEmail { get; set; }
        [Column("Company Fax")]
        [StringLength(30)]
        public string? CompanyFax { get; set; }
        [Column("Company Name")]
        [StringLength(80)]
        public string? CompanyName { get; set; }
        [Column("Company Postal")]
        [StringLength(10)]
        public string? CompanyPostal { get; set; }
        [Column("Company Tel")]
        [StringLength(30)]
        public string? CompanyTel { get; set; }
        [Column("Company Web Site")]
        [StringLength(50)]
        public string? CompanyWebSite { get; set; }
        [StringLength(50)]
        public string? Deparment { get; set; }
        [StringLength(50)]
        public string? Handphone { get; set; }
        [Column("Home Address 1")]
        [StringLength(50)]
        public string? HomeAddress1 { get; set; }
        [Column("Home Address 2")]
        [StringLength(50)]
        public string? HomeAddress2 { get; set; }
        [Column("Home Address 3")]
        [StringLength(50)]
        public string? HomeAddress3 { get; set; }
        [Column("Home Address 4")]
        [StringLength(50)]
        public string? HomeAddress4 { get; set; }
        [Column("Home City")]
        [StringLength(3)]
        public string? HomeCity { get; set; }
        [Column("Home Country")]
        [StringLength(2)]
        public string? HomeCountry { get; set; }
        [Column("Home Email")]
        [StringLength(50)]
        public string? HomeEmail { get; set; }
        [Column("Home Page")]
        [StringLength(50)]
        public string? HomePage { get; set; }
        [Column("Home Postal")]
        [StringLength(10)]
        public string? HomePostal { get; set; }
        [Column("Job Title")]
        [StringLength(20)]
        public string? JobTitle { get; set; }
        [Column("Last Name")]
        [StringLength(50)]
        public string? LastName { get; set; }
        [Column("Manager Name")]
        [StringLength(50)]
        public string? ManagerName { get; set; }
        [Column("Middle Name")]
        [StringLength(50)]
        public string? MiddleName { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Pager { get; set; }
        [Column("Spouse Name")]
        [StringLength(50)]
        public string? SpouseName { get; set; }
        [StringLength(5)]
        public string? Title { get; set; }
        [Column("User ID")]
        [MaxLength(50)]
        public byte[]? UserId { get; set; }
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
