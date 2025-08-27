using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaus3
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Special Right Flag")]
        [StringLength(1)]
        public string? SpecialRightFlag { get; set; }
        [Column("Special Right Name")]
        [StringLength(50)]
        public string? SpecialRightName { get; set; }
        [Column("User ID")]
        [StringLength(20)]
        public string? UserId { get; set; }
    }
}
