using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwExportSeaTrackpoint
    {
        [StringLength(2)]
        [Unicode(false)]
        public string JobType { get; set; } = null!;
        [Column("AWbBlNo")]
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("OBSNo")]
        [StringLength(1)]
        [Unicode(false)]
        public string Obsno { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? BkgJobDate { get; set; }
        [Column("FFRecvDate", TypeName = "datetime")]
        public DateTime? FfrecvDate { get; set; }
        [Column("ETD", TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        [Column("ETA", TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [StringLength(5)]
        public string? Origin { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(5)]
        public string? Dest { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("rcv_accept_date")]
        public int? RcvAcceptDate { get; set; }
        [Column("rcv_name")]
        [StringLength(1)]
        [Unicode(false)]
        public string RcvName { get; set; } = null!;
        [Column("TRK_CODE")]
        [StringLength(1)]
        [Unicode(false)]
        public string TrkCode { get; set; } = null!;
        [Column("TRK_BILL_NO")]
        [StringLength(1)]
        [Unicode(false)]
        public string TrkBillNo { get; set; } = null!;
        [Column("TRK_WEBSITE")]
        [StringLength(1)]
        [Unicode(false)]
        public string TrkWebsite { get; set; } = null!;
        [Column("URL")]
        [StringLength(1)]
        [Unicode(false)]
        public string Url { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string OrgCtrName { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string DestCtrName { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? PickupOn { get; set; }
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [Column("Date_0", TypeName = "datetime")]
        public DateTime? Date0 { get; set; }
        [Column("Location_0")]
        [StringLength(80)]
        public string? Location0 { get; set; }
        [Column("ActivityDesc_0")]
        [StringLength(20)]
        public string? ActivityDesc0 { get; set; }
        [Column("Date_1", TypeName = "datetime")]
        public DateTime? Date1 { get; set; }
        [Column("Location_1")]
        [StringLength(45)]
        public string? Location1 { get; set; }
        [Column("ActivityDesc_1")]
        [StringLength(14)]
        [Unicode(false)]
        public string ActivityDesc1 { get; set; } = null!;
        [Column("Date_2", TypeName = "datetime")]
        public DateTime? Date2 { get; set; }
        [Column("Location_2")]
        [StringLength(51)]
        public string Location2 { get; set; } = null!;
        [Column("ActivityDesc_2")]
        [StringLength(41)]
        [Unicode(false)]
        public string ActivityDesc2 { get; set; } = null!;
        [Column("Date_3", TypeName = "datetime")]
        public DateTime? Date3 { get; set; }
        [Column("Location_3")]
        [StringLength(51)]
        public string Location3 { get; set; } = null!;
        [Column("ActivityDesc_3")]
        [StringLength(42)]
        [Unicode(false)]
        public string ActivityDesc3 { get; set; } = null!;
        [Column("Date_4")]
        public int? Date4 { get; set; }
        [Column("Location_4")]
        [StringLength(1)]
        [Unicode(false)]
        public string Location4 { get; set; } = null!;
        [Column("ActivityDesc_4")]
        [StringLength(1)]
        [Unicode(false)]
        public string ActivityDesc4 { get; set; } = null!;
    }
}
