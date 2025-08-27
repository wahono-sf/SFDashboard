using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSapp6
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Document Template")]
        [StringLength(3000)]
        public string? DocumentTemplate { get; set; }
    }
}
