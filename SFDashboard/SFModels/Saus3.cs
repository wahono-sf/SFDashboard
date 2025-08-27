using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saus3")]
    public partial class Saus3
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? SpecialRightFlag { get; set; }
        [StringLength(50)]
        public string? SpecialRightName { get; set; }
        [StringLength(20)]
        public string? UserId { get; set; }
    }
}
