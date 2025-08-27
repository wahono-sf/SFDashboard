using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("wrUser")]
    public partial class WrUser
    {
        [StringLength(3000)]
        public string? Userword { get; set; }
    }
}
