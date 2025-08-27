using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("seat1")]
    public partial class Seat1
    {
        [StringLength(3000)]
        public string? EmailTemplate { get; set; }
        [StringLength(4)]
        public string? GroupName { get; set; }
    }
}
