using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("IvPst")]
    public partial class IvPst
    {
        [StringLength(4)]
        public string? TableName { get; set; }
        public int? TrxNo { get; set; }
    }
}
