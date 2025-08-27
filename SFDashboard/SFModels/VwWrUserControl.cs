using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrUserControl
    {
        [Column("last Use Date Time", TypeName = "datetime")]
        public DateTime LastUseDateTime { get; set; }
        [Column("Login Host Name")]
        [StringLength(200)]
        public string LoginHostName { get; set; } = null!;
        [Column("Net Word Mac Address")]
        [StringLength(400)]
        public string NetWordMacAddress { get; set; } = null!;
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
    }
}
