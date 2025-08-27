using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("Plcs_Post")]
    public partial class PlcsPost
    {
        [Column("KeyID")]
        public int KeyId { get; set; }
    }
}
