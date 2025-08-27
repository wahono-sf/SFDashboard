using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmfd2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("App Combine Day")]
        public int? AppCombineDay { get; set; }
        [Column("App Demurrage Day")]
        public int? AppDemurrageDay { get; set; }
        [Column("App Detention Day")]
        public int? AppDetentionDay { get; set; }
        [Column("Bl No")]
        [StringLength(30)]
        public string? BlNo { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Req Combine Day")]
        public int? ReqCombineDay { get; set; }
        [Column("Req Demurrage Day")]
        public int? ReqDemurrageDay { get; set; }
        [Column("Req Detention Day")]
        public int? ReqDetentionDay { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
    }
}
