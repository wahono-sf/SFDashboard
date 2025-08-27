using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaat1
    {
        [Column("Table Name")]
        [StringLength(50)]
        public string TableName { get; set; } = null!;
        [Column("Field Name")]
        [StringLength(50)]
        public string? FieldName { get; set; }
    }
}
