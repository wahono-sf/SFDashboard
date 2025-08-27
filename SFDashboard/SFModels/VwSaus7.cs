using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaus7
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Login Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? LoginDateTime { get; set; }
        [Column("Login Flag")]
        [StringLength(1)]
        public string? LoginFlag { get; set; }
        [Column("Logout Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? LogoutDateTime { get; set; }
        [Column("User ID")]
        [StringLength(20)]
        public string? UserId { get; set; }
    }
}
