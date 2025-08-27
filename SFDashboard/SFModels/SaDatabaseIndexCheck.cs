using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SaDatabaseIndexCheck
    {
        [Column("Table Id")]
        [StringLength(30)]
        public string? TableId { get; set; }
        public int? NoOfRow { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string ClusterIndexFlag { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string IndexFlag { get; set; } = null!;
    }
}
