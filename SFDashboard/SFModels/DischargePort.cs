using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class DischargePort
    {
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
    }
}
