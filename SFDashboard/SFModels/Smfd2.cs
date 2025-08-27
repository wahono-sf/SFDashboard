using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smfd2")]
    public partial class Smfd2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        public int? AppCombineDay { get; set; }
        public int? AppDemurrageDay { get; set; }
        public int? AppDetentionDay { get; set; }
        [StringLength(30)]
        public string? BlNo { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        public int? ReqCombineDay { get; set; }
        public int? ReqDemurrageDay { get; set; }
        public int? ReqDetentionDay { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
    }
}
