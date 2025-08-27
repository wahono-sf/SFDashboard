using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("sits2")]
    public partial class Sits2
    {
        public int? AvailQty { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BuyAmt { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? BuyUnitRate { get; set; }
        [Column("chgWt", TypeName = "decimal(13, 4)")]
        public decimal? ChgWt { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        public int? DeliveryQty { get; set; }
        public int? DiAvailQty { get; set; }
        public int? DiDeliverQty { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("FIataAmt", TypeName = "decimal(13, 2)")]
        public decimal? FiataAmt { get; set; }
        [Column("FIataRate", TypeName = "decimal(13, 4)")]
        public decimal? FiataRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWt { get; set; }
        [StringLength(3)]
        public string? LineNo { get; set; }
        [StringLength(25)]
        public string? MarkOrNo { get; set; }
        public int? Qty { get; set; }
        [StringLength(15)]
        public string? SealNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SellAmt { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? SellRate { get; set; }
        [StringLength(1)]
        public string? TextFlag { get; set; }
        [StringLength(6)]
        public string? TrxNo { get; set; }
        [StringLength(50)]
        public string? Uom { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Vol { get; set; }

        [ForeignKey("ContainerType")]
        public virtual Rcco1? ContainerTypeNavigation { get; set; }
    }
}
