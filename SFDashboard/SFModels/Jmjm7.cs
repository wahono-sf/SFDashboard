using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmjm7")]
    public partial class Jmjm7
    {
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public int JobLineItemNo { get; set; }
        [Key]
        public int EventLineItemNo { get; set; }
        [StringLength(255)]
        public string? BccEmailAddress { get; set; }
        [Column("CCEmailAddress")]
        [StringLength(255)]
        public string? CcemailAddress { get; set; }
        [StringLength(3000)]
        public string? EmailBody { get; set; }
        [StringLength(255)]
        public string? Subject { get; set; }
        [StringLength(255)]
        public string? ToEmailAddress { get; set; }
    }
}
