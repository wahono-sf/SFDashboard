using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrUserControl")]
    public partial class WrUserControl
    {
        [Key]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [Key]
        [StringLength(400)]
        public string NetWordMacAddress { get; set; } = null!;
        [Column("lastUseDateTime", TypeName = "datetime")]
        public DateTime LastUseDateTime { get; set; }
        [StringLength(200)]
        public string LoginHostName { get; set; } = null!;
    }
}
