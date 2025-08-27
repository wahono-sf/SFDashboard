using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saus7")]
    [Index("LoginDateTime", Name = "INDEX_saus7_LoginDateTime")]
    [Index("LogoutDateTime", Name = "INDEX_saus7_LogoutDateTime")]
    [Index("UserId", Name = "INDEX_saus7_UserID")]
    public partial class Saus7
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LoginDateTime { get; set; }
        [StringLength(1)]
        public string? LoginFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LogoutDateTime { get; set; }
        [Column("UserID")]
        [StringLength(20)]
        public string? UserId { get; set; }
    }
}
