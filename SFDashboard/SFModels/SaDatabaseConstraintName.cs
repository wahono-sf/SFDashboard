using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SaDatabaseConstraintName
    {
        [Column("Constraint Name")]
        [StringLength(128)]
        public string ConstraintName { get; set; } = null!;
        [Column("Primary Table")]
        [StringLength(128)]
        public string PrimaryTable { get; set; } = null!;
        [Column("Primary Column")]
        [StringLength(128)]
        public string PrimaryColumn { get; set; } = null!;
        [Column("Foreign Table")]
        [StringLength(128)]
        public string ForeignTable { get; set; } = null!;
        [Column("Foreign Column")]
        [StringLength(128)]
        public string ForeignColumn { get; set; } = null!;
    }
}
