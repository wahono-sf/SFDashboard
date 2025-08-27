using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class AvailPort
    {
        [Column("Port Code")]
        [StringLength(5)]
        public string? PortCode { get; set; }
        [Column("Port Name")]
        [StringLength(45)]
        public string? PortName { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
    }
}
