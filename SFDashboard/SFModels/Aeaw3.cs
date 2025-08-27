using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aeaw3")]
    public partial class Aeaw3
    {
        [Key]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Key]
        public int PcsSeqNo { get; set; }
    }
}
