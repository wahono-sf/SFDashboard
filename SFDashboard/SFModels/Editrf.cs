using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("EDITrf")]
    public partial class Editrf
    {
        [StringLength(4)]
        public string? TableName { get; set; }
        public int? TrxNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
    }
}
