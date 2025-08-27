using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("PlPst")]
    public partial class PlPst
    {
        [StringLength(4)]
        public string? TableName { get; set; }
        public int? TrxNo { get; set; }
    }
}
