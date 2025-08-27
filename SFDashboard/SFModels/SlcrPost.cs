using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("Slcr_Post")]
    public partial class SlcrPost
    {
        public int TrxNo { get; set; }
    }
}
