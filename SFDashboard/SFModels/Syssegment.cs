using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class Syssegment
    {
        public int Segment { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        public int Status { get; set; }
    }
}
