using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImportSeaTrackpoints20160902
    {
        [Column("AWbBlNo")]
        [StringLength(30)]
        public string AwbBlNo { get; set; } = null!;
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeOnhand { get; set; }
        [Column("ETD", TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        [Column("ETA", TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [StringLength(5)]
        public string? Origin { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("dest")]
        [StringLength(5)]
        public string? Dest { get; set; }
        [Column("destName")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DrDlDate { get; set; }
        [StringLength(50)]
        public string? SignBy { get; set; }
        [Column("SignID")]
        [StringLength(17)]
        public string? SignId { get; set; }
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [StringLength(80)]
        public string? DeliverToName { get; set; }
        [StringLength(45)]
        public string? DeliverToAddress1 { get; set; }
        [StringLength(45)]
        public string? DeliverToAddress2 { get; set; }
        [StringLength(45)]
        public string? DeliverToAddress3 { get; set; }
        [StringLength(45)]
        public string? DeliverToAddress4 { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string OrgCtrName { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string DestCtrName { get; set; } = null!;
        [StringLength(22)]
        public string? DeliveryOrderNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CargoReadyDate { get; set; }
        [Column("Location_0")]
        [StringLength(80)]
        public string? Location0 { get; set; }
        [Column("ActivityDesc_0")]
        [StringLength(9)]
        public string? ActivityDesc0 { get; set; }
        [Column("Location_1")]
        [StringLength(51)]
        public string Location1 { get; set; } = null!;
        [Column("ActivityDesc_1")]
        [StringLength(41)]
        [Unicode(false)]
        public string ActivityDesc1 { get; set; } = null!;
        [Column("Location_2")]
        [StringLength(51)]
        public string Location2 { get; set; } = null!;
        [Column("ActivityDesc_2")]
        [StringLength(42)]
        [Unicode(false)]
        public string ActivityDesc2 { get; set; } = null!;
        [Column("Location_3")]
        [StringLength(80)]
        public string? Location3 { get; set; }
        [Column("ActivityDesc_3")]
        [StringLength(139)]
        public string? ActivityDesc3 { get; set; }
    }
}
