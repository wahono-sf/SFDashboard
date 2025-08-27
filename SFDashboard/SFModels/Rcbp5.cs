using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("rcbp5")]
    public partial class Rcbp5
    {
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [StringLength(3)]
        public string PartyCode { get; set; } = null!;
    }
}
