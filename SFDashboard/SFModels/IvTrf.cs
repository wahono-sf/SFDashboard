using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("IvTrf")]
    public partial class IvTrf
    {
        [StringLength(4)]
        public string? TableName { get; set; }
        public int? TrxNo { get; set; }
    }
}
