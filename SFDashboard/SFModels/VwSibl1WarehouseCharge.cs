using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSibl1WarehouseCharge
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("FKL")]
        [StringLength(13)]
        public string? Fkl { get; set; }
        [Column("TRA")]
        [StringLength(13)]
        public string? Tra { get; set; }
        [Column("DPF")]
        [StringLength(13)]
        public string? Dpf { get; set; }
        [Column("ADF")]
        [StringLength(13)]
        public string? Adf { get; set; }
        [Column("WMC")]
        [StringLength(13)]
        public string? Wmc { get; set; }
        [Column("WAS")]
        [StringLength(13)]
        public string? Was { get; set; }
        [Column("DEP")]
        [StringLength(13)]
        public string? Dep { get; set; }
        [Column("OTH")]
        [StringLength(13)]
        public string? Oth { get; set; }
        [Column("WHC")]
        [StringLength(13)]
        public string? Whc { get; set; }
        [Column("FTZ")]
        [StringLength(13)]
        public string? Ftz { get; set; }
    }
}
