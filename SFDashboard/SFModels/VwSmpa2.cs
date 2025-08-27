using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmpa2
    {
        [Column("Cargo Type")]
        [StringLength(50)]
        public string? CargoType { get; set; }
        [Column("Column Name")]
        [StringLength(50)]
        public string? ColumnName { get; set; }
        [Column("Sequence No")]
        public int? SequenceNo { get; set; }
    }
}
