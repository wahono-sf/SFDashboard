using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaco5
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("User Licence Key")]
        [StringLength(2000)]
        public string? UserLicenceKey { get; set; }
        [Column("Create Date Time", TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
    }
}
