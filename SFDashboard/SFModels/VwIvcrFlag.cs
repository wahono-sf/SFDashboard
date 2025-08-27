using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwIvcrFlag
    {
        [StringLength(50)]
        public string Keyvalue { get; set; } = null!;
        [StringLength(20)]
        public string FlagCode { get; set; } = null!;
    }
}
