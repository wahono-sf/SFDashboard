using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSebkNomination
    {
        [Column("No of NominationFlag")]
        public int? NoOfNominationFlag { get; set; }
        [Column("Master Job No")]
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
    }
}
