using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("PvExp")]
    public partial class PvExp
    {
        [StringLength(4)]
        public string? TableName { get; set; }
        public int? TrxNo { get; set; }
        public int? TrxType { get; set; }
        [StringLength(10)]
        public string? VoucherNo { get; set; }
    }
}
