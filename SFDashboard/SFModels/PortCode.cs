using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class PortCode
    {
        [Column("PortCode")]
        [StringLength(5)]
        public string PortCode1 { get; set; } = null!;
        [StringLength(45)]
        public string? PortName { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
    }
}
