using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmsr1
    {
        [Column("Arrival Gateway Code")]
        [StringLength(6)]
        public string? ArrivalGatewayCode { get; set; }
        [Column("Cancellation Rmk")]
        [StringLength(75)]
        public string? CancellationRmk { get; set; }
        [Column("Collection Point")]
        [StringLength(75)]
        public string? CollectionPoint { get; set; }
        [Column("Consignee Code")]
        [StringLength(8)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Code Plexis")]
        [StringLength(8)]
        public string? ConsigneeCodePlexis { get; set; }
        [Column("Contract Number")]
        [StringLength(20)]
        public string? ContractNumber { get; set; }
        [Column("Contract Repair Vote")]
        [StringLength(10)]
        public string? ContractRepairVote { get; set; }
        [Column("Contr Client Code")]
        [StringLength(8)]
        public string? ContrClientCode { get; set; }
        [Column("Cp Contact No")]
        [StringLength(20)]
        public string? CpContactNo { get; set; }
        [Column("Cp Contact Person")]
        [StringLength(30)]
        public string? CpContactPerson { get; set; }
        [Column("Cp Fax No")]
        [StringLength(20)]
        public string? CpFaxNo { get; set; }
        [Column("Customer Reference")]
        [StringLength(20)]
        public string? CustomerReference { get; set; }
        [Column("Date Time Added")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeAdded { get; set; }
        [Column("Date Time Changed")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeChanged { get; set; }
        [Column("Date Time Pick Up By Ff")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimePickUpByFf { get; set; }
        [Column("Date Time Pick Up By Ff Gmt")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimePickUpByFfGmt { get; set; }
        [Column("Date Time Ready For Pick Up")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DateTimeReadyForPickUp { get; set; }
        [Column("Departure Gateway Code")]
        [StringLength(6)]
        public string? DepartureGatewayCode { get; set; }
        [Column("Dg Indicator")]
        [StringLength(1)]
        public string? DgIndicator { get; set; }
        [Column("Es Request No")]
        [StringLength(10)]
        public string? EsRequestNo { get; set; }
        [Column("Explosive Indicator")]
        [StringLength(1)]
        public string? ExplosiveIndicator { get; set; }
        [Column("Ff Received Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? FfReceivedDateTime { get; set; }
        [Column("Ff Received Date Time Gmt")]
        [StringLength(16)]
        [Unicode(false)]
        public string? FfReceivedDateTimeGmt { get; set; }
        [Column("Hawb Hbl No")]
        [StringLength(20)]
        public string? HawbHblNo { get; set; }
        [Column("Issuer Code")]
        [StringLength(8)]
        public string? IssuerCode { get; set; }
        [Column("Issuer Changed")]
        [StringLength(8)]
        public string? IssuerChanged { get; set; }
        [Column("Imco Class")]
        [StringLength(5)]
        public string? ImcoClass { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("License Info")]
        [StringLength(75)]
        public string? LicenseInfo { get; set; }
        [Column("License No")]
        [StringLength(20)]
        public string? LicenseNo { get; set; }
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Mawb Obl No")]
        [StringLength(20)]
        public string? MawbOblNo { get; set; }
        [Column("Method Of Despatch")]
        [StringLength(35)]
        public string? MethodOfDespatch { get; set; }
        [Column("Mode Of Payment")]
        [StringLength(50)]
        public string? ModeOfPayment { get; set; }
        [Column(TypeName = "decimal(11, 6)")]
        public decimal? Neq { get; set; }
        [Column("Notify Name")]
        [StringLength(80)]
        public string? NotifyName { get; set; }
        [Column("Notify Address 1")]
        [StringLength(36)]
        public string? NotifyAddress1 { get; set; }
        [Column("Notify Address 2")]
        [StringLength(36)]
        public string? NotifyAddress2 { get; set; }
        [Column("Notify Address 3")]
        [StringLength(36)]
        public string? NotifyAddress3 { get; set; }
        [Column("Notify Address 4")]
        [StringLength(36)]
        public string? NotifyAddress4 { get; set; }
        [Column("Obl Job No")]
        [StringLength(20)]
        public string? OblJobNo { get; set; }
        [Column("Reasons For Despatch")]
        [StringLength(40)]
        public string? ReasonsForDespatch { get; set; }
        [Column("Rec Status")]
        [StringLength(2)]
        public string? RecStatus { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Req Client Code")]
        [StringLength(4)]
        public string? ReqClientCode { get; set; }
        [Column("Request Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? RequestDateTime { get; set; }
        [Column("Request Number")]
        [StringLength(12)]
        public string RequestNumber { get; set; } = null!;
        [StringLength(8)]
        public string? Requestor { get; set; }
        [Column("Requestor Appointment")]
        [StringLength(30)]
        public string? RequestorAppointment { get; set; }
        [Column("Requestor Email ID")]
        [StringLength(30)]
        public string? RequestorEmailId { get; set; }
        [Column("Requestor Fax Number")]
        [StringLength(20)]
        public string? RequestorFaxNumber { get; set; }
        [Column("Requestor IC Number")]
        [StringLength(10)]
        public string? RequestorIcNumber { get; set; }
        [Column("Requestor Name")]
        [StringLength(30)]
        public string? RequestorName { get; set; }
        [Column("Requestor Phone")]
        [StringLength(20)]
        public string? RequestorPhone { get; set; }
        [Column("Requestor Unit")]
        [StringLength(30)]
        public string? RequestorUnit { get; set; }
        [Column("Shipment Flag")]
        [StringLength(2)]
        public string? ShipmentFlag { get; set; }
        [Column("Shipper Code")]
        [StringLength(8)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipper Code Plexis")]
        [StringLength(8)]
        public string? ShipperCodePlexis { get; set; }
        [Column("Special Shipper Instruction")]
        [StringLength(250)]
        public string? SpecialShipperInstruction { get; set; }
        [Column("Total Grosss Weight", TypeName = "decimal(11, 2)")]
        public decimal? TotalGrosssWeight { get; set; }
        [Column("Total Item Value", TypeName = "decimal(11, 2)")]
        public decimal? TotalItemValue { get; set; }
        [Column("Total No Of Packages", TypeName = "decimal(11, 2)")]
        public decimal? TotalNoOfPackages { get; set; }
        [Column("Total Volume", TypeName = "decimal(12, 3)")]
        public decimal? TotalVolume { get; set; }
        [Column("Type Of System")]
        [StringLength(20)]
        public string? TypeOfSystem { get; set; }
        [Column("Un No")]
        [StringLength(4)]
        public string? UnNo { get; set; }
        [Column("Vote In")]
        [StringLength(10)]
        public string? VoteIn { get; set; }
        [Column("Vote Out")]
        [StringLength(10)]
        public string? VoteOut { get; set; }
    }
}
