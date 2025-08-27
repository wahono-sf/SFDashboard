using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSavl1
    {
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Actual Value")]
        [StringLength(50)]
        public string? ActualValue { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Field Name")]
        [StringLength(50)]
        public string FieldName { get; set; } = null!;
        [Column("Table Name")]
        [StringLength(50)]
        public string TableName { get; set; } = null!;
        [StringLength(3)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
