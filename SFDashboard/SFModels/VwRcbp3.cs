using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbp3
    {
        [Column("Business Party Code")]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthday { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(50)]
        public string? Department { get; set; }
        [StringLength(50)]
        public string? Dislike { get; set; }
        [StringLength(50)]
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
        [Column("Name Card", TypeName = "image")]
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
