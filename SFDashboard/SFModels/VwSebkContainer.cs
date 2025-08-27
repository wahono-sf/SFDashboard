using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSebkContainer
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("No Of Container")]
        public int? NoOfContainer { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Container Description")]
        [StringLength(50)]
        public string? ContainerDescription { get; set; }
    }
}
