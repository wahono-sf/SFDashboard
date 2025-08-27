using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slcu5")]
    public partial class Slcu5
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime AgeingDate { get; set; }
    }
}
