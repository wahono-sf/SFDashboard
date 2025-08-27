using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plvn4")]
    public partial class Plvn4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime AgeingDate { get; set; }
    }
}
