using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("saat1")]
    public partial class Saat1
    {
        [StringLength(50)]
        public string TableName { get; set; } = null!;
        [StringLength(50)]
        public string? FieldName { get; set; }
    }
}
