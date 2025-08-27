using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("PlTrf")]
    public partial class PlTrf
    {
        public int? TrxNo { get; set; }
        [StringLength(4)]
        public string? TableName { get; set; }
    }
}
