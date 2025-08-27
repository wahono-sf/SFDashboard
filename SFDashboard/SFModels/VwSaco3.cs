using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaco3
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Clear Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ClearDateTime { get; set; }
        [Column("Clear User Computer Name")]
        [StringLength(50)]
        public string? ClearUserComputerName { get; set; }
        [Column("Clear User ID")]
        [StringLength(50)]
        public string? ClearUserId { get; set; }
        [Column("Licence Exceed Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? LicenceExceedDateTime { get; set; }
        [Column("User ID")]
        [StringLength(50)]
        public string? UserId { get; set; }
    }
}
