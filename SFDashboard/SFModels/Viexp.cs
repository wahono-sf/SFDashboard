using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("VIExp")]
    public partial class Viexp
    {
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        public int? TrxNo { get; set; }
    }
}
