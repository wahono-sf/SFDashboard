using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcbp3")]
    [Index("ContactName", Name = "INDEX_Rcbp3_ContactName")]
    [Index("Email", Name = "INDEX_Rcbp3_Email")]
    [Index("Fax", Name = "INDEX_Rcbp3_Fax")]
    [Index("Telephone", Name = "INDEX_Rcbp3_Telephone")]
    public partial class Rcbp3
    {
        [Key]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthday { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(50)]
        public string? Department { get; set; }
        [StringLength(50)]
        public string? Dislike { get; set; }
        [StringLength(100)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Facebook { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [StringLength(30)]
        public string? Handphone { get; set; }
        [StringLength(50)]
        public string? Like { get; set; }
        [Column("MSN")]
        [StringLength(50)]
        public string? Msn { get; set; }
        [Column(TypeName = "image")]
        public byte[]? NameCard { get; set; }
        [StringLength(50)]
        public string? Others { get; set; }
        [Column("QQ")]
        [StringLength(50)]
        public string? Qq { get; set; }
        [StringLength(50)]
        public string? Skype { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(20)]
        public string? Title { get; set; }
        [StringLength(50)]
        public string? Twitter { get; set; }
    }
}
