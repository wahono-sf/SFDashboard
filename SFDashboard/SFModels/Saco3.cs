using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("saco3")]
    public partial class Saco3
    {
        public int TrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClearDateTime { get; set; }
        [StringLength(50)]
        public string? ClearUserComputerName { get; set; }
        [Column("ClearUserID")]
        [StringLength(50)]
        public string? ClearUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenceExceedDateTime { get; set; }
        [Column("UserID")]
        [StringLength(50)]
        public string? UserId { get; set; }
    }
}
