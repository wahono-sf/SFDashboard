using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSeblContainer
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("No Of Container")]
        public int? NoOfContainer { get; set; }
        [Column("No Of TEU", TypeName = "decimal(38, 2)")]
        public decimal? NoOfTeu { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Container Description")]
        [StringLength(50)]
        public string? ContainerDescription { get; set; }
    }
}
