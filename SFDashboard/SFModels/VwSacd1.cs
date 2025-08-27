using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSacd1
    {
        [Column("Table Name")]
        [StringLength(10)]
        public string? TableName { get; set; }
        [Column("Database Name")]
        [StringLength(50)]
        public string? DatabaseName { get; set; }
    }
}
