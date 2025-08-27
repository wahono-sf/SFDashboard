using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("smpa2")]
    public partial class Smpa2
    {
        public int? SequenceNo { get; set; }
        [StringLength(50)]
        public string? CargoType { get; set; }
        [StringLength(50)]
        public string? ColumnName { get; set; }
    }
}
