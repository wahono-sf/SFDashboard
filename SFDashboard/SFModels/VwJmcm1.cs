using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmcm1
    {
        [Column("Bl No")]
        [StringLength(20)]
        public string? BlNo { get; set; }
        [Column("Container Return Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ContainerReturnDate { get; set; }
        [Column("Container Return Type")]
        [StringLength(1)]
        public string? ContainerReturnType { get; set; }
        [Column("Container Transfer Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ContainerTransferDate { get; set; }
        [Column("Container Remark")]
        [StringLength(500)]
        public string? ContainerRemark { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("DO Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DoReleaseDate { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Final Dest Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FinalDestDate { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        [Unicode(false)]
        public string ModuleCode { get; set; } = null!;
        [Column("Job Type")]
        [StringLength(2)]
        public string? JobType { get; set; }
    }
}
