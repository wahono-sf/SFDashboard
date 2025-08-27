using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sapb1")]
    public partial class Sapb1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthday { get; set; }
        [StringLength(50)]
        public string? ChildrenName { get; set; }
        [StringLength(50)]
        public string? CompanyAddress { get; set; }
        [StringLength(50)]
        public string? CompanyAddress1 { get; set; }
        [StringLength(50)]
        public string? CompanyAddress2 { get; set; }
        [StringLength(50)]
        public string? CompanyAddress3 { get; set; }
        [StringLength(50)]
        public string? CompanyAddress4 { get; set; }
        [StringLength(3)]
        public string? CompanyCity { get; set; }
        [StringLength(2)]
        public string? CompanyCountry { get; set; }
        [StringLength(50)]
        public string? CompanyEmail { get; set; }
        [StringLength(30)]
        public string? CompanyFax { get; set; }
        [StringLength(80)]
        public string? CompanyName { get; set; }
        [StringLength(10)]
        public string? CompanyPostal { get; set; }
        [StringLength(30)]
        public string? CompanyTel { get; set; }
        [StringLength(50)]
        public string? CompanyWebSite { get; set; }
        [StringLength(50)]
        public string? Deparment { get; set; }
        [StringLength(50)]
        public string? Handphone { get; set; }
        [StringLength(50)]
        public string? HomeAddress1 { get; set; }
        [StringLength(50)]
        public string? HomeAddress2 { get; set; }
        [StringLength(50)]
        public string? HomeAddress3 { get; set; }
        [StringLength(50)]
        public string? HomeAddress4 { get; set; }
        [StringLength(3)]
        public string? HomeCity { get; set; }
        [StringLength(2)]
        public string? HomeCountry { get; set; }
        [StringLength(50)]
        public string? HomeEmail { get; set; }
        [StringLength(50)]
        public string? HomePage { get; set; }
        [StringLength(10)]
        public string? HomePostal { get; set; }
        [StringLength(20)]
        public string? JobTitle { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [StringLength(50)]
        public string? ManagerName { get; set; }
        [StringLength(50)]
        public string? MiddleName { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Pager { get; set; }
        [StringLength(50)]
        public string? SpouseName { get; set; }
        [StringLength(5)]
        public string? Title { get; set; }
        [Column("UserID")]
        [MaxLength(50)]
        public byte[]? UserId { get; set; }
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
