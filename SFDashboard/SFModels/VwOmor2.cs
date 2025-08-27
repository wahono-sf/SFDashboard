using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmor2
    {
        [Column("Contr No")]
        [StringLength(16)]
        public string? ContrNo { get; set; }
        [Column("Amend No")]
        [StringLength(14)]
        public string? AmendNo { get; set; }
        [Column("Amend Term Code")]
        [StringLength(1)]
        public string? AmendTermCode { get; set; }
        [StringLength(8)]
        public string? ClientCode { get; set; }
        [Column("Contact Fax No")]
        [StringLength(15)]
        public string? ContactFaxNo { get; set; }
        [Column("Contact Phone No")]
        [StringLength(15)]
        public string? ContactPhoneNo { get; set; }
        [Column("Contr Type")]
        [StringLength(1)]
        public string? ContrType { get; set; }
        [Column("Contr Var No")]
        [StringLength(14)]
        public string? ContrVarNo { get; set; }
        [Column("Conver Rate", TypeName = "decimal(16, 4)")]
        public decimal? ConverRate { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Date Time Added")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeAdded { get; set; }
        [Column("Date Time Changed")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeChanged { get; set; }
        [Column("Date Time Contr End")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeContrEnd { get; set; }
        [Column("Date Time Contr Start")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeContrStart { get; set; }
        [Column("Date Time Delivery")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeDelivery { get; set; }
        [Column("Date Time Last Recv")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeLastRecv { get; set; }
        [Column("Date Time Tfer")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeTfer { get; set; }
        [Column("Delivery Term")]
        [StringLength(3)]
        public string? DeliveryTerm { get; set; }
        [StringLength(30)]
        public string? Email { get; set; }
        [Column("Explosive Flag")]
        [StringLength(1)]
        public string? ExplosiveFlag { get; set; }
        [Column("Fms Assist Type")]
        [StringLength(1)]
        public string? FmsAssistType { get; set; }
        [Column("Fms Contr No")]
        [StringLength(14)]
        public string? FmsContrNo { get; set; }
        [Column("Fms Item No")]
        [StringLength(4)]
        public string? FmsItemNo { get; set; }
        [Column("Fms Mos From")]
        [StringLength(3)]
        public string? FmsMosFrom { get; set; }
        [Column("Fms Mos To")]
        [StringLength(3)]
        public string? FmsMosTo { get; set; }
        [Column("Fms Offer Rel Code")]
        [StringLength(1)]
        public string? FmsOfferRelCode { get; set; }
        [Column("Fms Src Code")]
        [StringLength(1)]
        public string? FmsSrcCode { get; set; }
        [Column("Fms Training Note")]
        [StringLength(2)]
        public string? FmsTrainingNote { get; set; }
        [Column("Frt Forw")]
        [StringLength(150)]
        public string? FrtForw { get; set; }
        [StringLength(3)]
        public string? Hd { get; set; }
        [Column("Gate Way Code")]
        [StringLength(150)]
        public string? GateWayCode { get; set; }
        [Column("Item Desc")]
        [StringLength(40)]
        public string? ItemDesc { get; set; }
        [Column("Item No")]
        [StringLength(4)]
        public string? ItemNo { get; set; }
        [Column("Material Grp")]
        [StringLength(14)]
        public string? MaterialGrp { get; set; }
        [Column("Min Shelf Life")]
        [StringLength(4)]
        public string? MinShelfLife { get; set; }
        [StringLength(32)]
        public string? Mpn { get; set; }
        [Column(TypeName = "decimal(10, 6)")]
        public decimal? Neq { get; set; }
        [Column("Net Total Amt", TypeName = "decimal(16, 4)")]
        public decimal? NetTotalAmt { get; set; }
        [StringLength(10)]
        public string? Niin { get; set; }
        [Column("No Of Pcs", TypeName = "decimal(16, 4)")]
        public decimal? NoOfPcs { get; set; }
        [StringLength(4)]
        public string? Nsc { get; set; }
        [Column("Option Flag")]
        [StringLength(1)]
        public string? OptionFlag { get; set; }
        [Column("Pe Dept")]
        [StringLength(40)]
        public string? PeDept { get; set; }
        [Column("Pe Fax")]
        [StringLength(30)]
        public string? PeFax { get; set; }
        [Column("Pe Init")]
        [StringLength(4)]
        public string? PeInit { get; set; }
        [Column("Pe Phone No")]
        [StringLength(30)]
        public string? PePhoneNo { get; set; }
        [Column("Pe Rank Name")]
        [StringLength(80)]
        public string? PeRankName { get; set; }
        [Column("Place Delivery")]
        [StringLength(200)]
        public string? PlaceDelivery { get; set; }
        [Column("Pr Item No")]
        [StringLength(4)]
        public string? PrItemNo { get; set; }
        [Column("Pr No")]
        [StringLength(14)]
        public string? PrNo { get; set; }
        [Column("Princ Contr Item No")]
        [StringLength(4)]
        public string? PrincContrItemNo { get; set; }
        [Column("Princ Contr No")]
        [StringLength(14)]
        public string? PrincContrNo { get; set; }
        [Column("Priority Ind")]
        [StringLength(2)]
        public string? PriorityInd { get; set; }
        [Column("Qty Recv", TypeName = "decimal(16, 4)")]
        public decimal? QtyRecv { get; set; }
        [Column("Rec Status")]
        [StringLength(2)]
        public string? RecStatus { get; set; }
        [StringLength(1)]
        public string? Scg { get; set; }
        [Column("Security Class")]
        [StringLength(1)]
        public string? SecurityClass { get; set; }
        [Column("Service Code")]
        [StringLength(5)]
        public string? ServiceCode { get; set; }
        [Column("Sub Vote No")]
        [StringLength(3)]
        public string? SubVoteNo { get; set; }
        [Column("Supplier Code")]
        [StringLength(12)]
        public string? SupplierCode { get; set; }
        [Column("Supplier Contact")]
        [StringLength(30)]
        public string? SupplierContact { get; set; }
        [Column("Tfer Status")]
        [StringLength(2)]
        public string? TferStatus { get; set; }
        [Column("Total Amt L", TypeName = "decimal(16, 4)")]
        public decimal? TotalAmtL { get; set; }
        [Column("Unit Meas")]
        [StringLength(3)]
        public string? UnitMeas { get; set; }
        [Column("Unit Price", TypeName = "decimal(16, 4)")]
        public decimal? UnitPrice { get; set; }
        [Column("Un No")]
        [StringLength(4)]
        public string? UnNo { get; set; }
        [Column("Vote No")]
        [StringLength(10)]
        public string? VoteNo { get; set; }
    }
}
