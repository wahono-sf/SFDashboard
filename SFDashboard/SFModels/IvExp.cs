using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("IvExp")]
    public partial class IvExp
    {
        [StringLength(10)]
        public string? InvoiceNo { get; set; }
        [StringLength(4)]
        public string? TableName { get; set; }
        public int? TrxNo { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
    }
}
