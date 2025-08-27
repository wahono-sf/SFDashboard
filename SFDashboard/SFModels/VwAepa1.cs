using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAepa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column("Agent Name")]
        [StringLength(80)]
        public string? AgentName { get; set; }
        [Column("Agent Acc Code")]
        [StringLength(15)]
        public string? AgentAccCode { get; set; }
        [Column("Agent Address 1")]
        [StringLength(60)]
        public string? AgentAddress1 { get; set; }
        [Column("Agent Address 2")]
        [StringLength(60)]
        public string? AgentAddress2 { get; set; }
        [Column("Agent Address 3")]
        [StringLength(60)]
        public string? AgentAddress3 { get; set; }
        [Column("Agent Address 4")]
        [StringLength(60)]
        public string? AgentAddress4 { get; set; }
        [Column("Agent Iata Code")]
        [StringLength(25)]
        public string? AgentIataCode { get; set; }
        [Column("Agent Party Type")]
        [StringLength(3)]
        public string? AgentPartyType { get; set; }
        [Column("Auto HAwb No Flag")]
        [StringLength(1)]
        public string? AutoHawbNoFlag { get; set; }
        [Column("Auto MAwb No Flag")]
        [StringLength(1)]
        public string? AutoMawbNoFlag { get; set; }
        [Column("Awb Curr Code")]
        [StringLength(3)]
        public string? AwbCurrCode { get; set; }
        [Column("AWB Item Code")]
        [StringLength(30)]
        public string? AwbItemCode { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Booking Create Job No Flag")]
        [StringLength(1)]
        public string? BookingCreateJobNoFlag { get; set; }
        [Column("Cargo Manifest Prefix")]
        [StringLength(3)]
        public string? CargoManifestPrefix { get; set; }
        [Column("Cash Acc Code")]
        [StringLength(15)]
        public string? CashAccCode { get; set; }
        [Column("Change Master Awb No Flag")]
        [StringLength(1)]
        public string? ChangeMasterAwbNoFlag { get; set; }
        [Column("Charge Weight Flag")]
        [StringLength(1)]
        public string? ChargeWeightFlag { get; set; }
        [Column("Consol Booking Flag")]
        [StringLength(1)]
        public string? ConsolBookingFlag { get; set; }
        [Column("Consol Job Flag")]
        [StringLength(1)]
        public string? ConsolJobFlag { get; set; }
        [Column("Consol Show Awb Flag")]
        [StringLength(1)]
        public string? ConsolShowAwbFlag { get; set; }
        [Column("Consol Sub Master Flag")]
        [StringLength(1)]
        public string? ConsolSubMasterFlag { get; set; }
        [Column("Courier Item Code")]
        [StringLength(30)]
        public string? CourierItemCode { get; set; }
        [Column("Courier Surcharge Rate", TypeName = "decimal(13, 2)")]
        public decimal? CourierSurchargeRate { get; set; }
        [Column("Csr Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CsrDate { get; set; }
        [Column("Dc Note Prefix")]
        [StringLength(3)]
        public string? DcNotePrefix { get; set; }
        [Column("Dc Note Seq No")]
        [StringLength(5)]
        public string? DcNoteSeqNo { get; set; }
        [Column("Default Commodity Description")]
        [StringLength(50)]
        public string? DefaultCommodityDescription { get; set; }
        [Column("Default Other")]
        [StringLength(1)]
        public string? DefaultOther { get; set; }
        [Column("Default Same As Consignee Flag")]
        [StringLength(1)]
        public string? DefaultSameAsConsigneeFlag { get; set; }
        [Column("Default Uom Code")]
        [StringLength(50)]
        public string? DefaultUomCode { get; set; }
        [Column("Default Volumetric Weight Ratio")]
        public short? DefaultVolumetricWeightRatio { get; set; }
        [Column("Default Weight Value")]
        [StringLength(1)]
        public string? DefaultWeightValue { get; set; }
        [Column("Departure Airport Name")]
        [StringLength(45)]
        public string? DepartureAirportName { get; set; }
        [Column("Deviceaddr Ccn")]
        [StringLength(3)]
        public string? DeviceaddrCcn { get; set; }
        [Column("Dg Cargo Remark")]
        [StringLength(80)]
        public string? DgCargoRemark { get; set; }
        [Column("Dimension Separation")]
        [StringLength(1)]
        public string? DimensionSeparation { get; set; }
        [Column("Direct House Flag")]
        [StringLength(1)]
        public string? DirectHouseFlag { get; set; }
        [Column("Document Footer 1")]
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        [Column("Document Footer 2")]
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        [Column("Ec Freight Flag")]
        [StringLength(1)]
        public string? EcFreightFlag { get; set; }
        [Column("Filter Consignee Flag")]
        [StringLength(1)]
        public string? FilterConsigneeFlag { get; set; }
        [Column("Font Type")]
        [StringLength(50)]
        public string? FontType { get; set; }
        [Column("Frt Amt Round Up Flag")]
        [StringLength(1)]
        public string? FrtAmtRoundUpFlag { get; set; }
        [Column("Frt Item Code 1")]
        [StringLength(30)]
        public string? FrtItemCode1 { get; set; }
        [Column("Frt Item Code 2")]
        [StringLength(30)]
        public string? FrtItemCode2 { get; set; }
        [Column("Frt Item Code 3")]
        [StringLength(30)]
        public string? FrtItemCode3 { get; set; }
        [Column("Fsc Item Code")]
        [StringLength(30)]
        public string? FscItemCode { get; set; }
        [Column("H Awb No Flag")]
        [StringLength(1)]
        public string? HAwbNoFlag { get; set; }
        [Column("H Awb Prefix")]
        [StringLength(11)]
        public string? HAwbPrefix { get; set; }
        [Column("Hide Import Job Flag")]
        [StringLength(1)]
        public string? HideImportJobFlag { get; set; }
        [Column("IATA Round Flag")]
        [StringLength(1)]
        public string? IataRoundFlag { get; set; }
        [Column("Iss Item Code")]
        [StringLength(30)]
        public string? IssItemCode { get; set; }
        [Column("Job Date Type")]
        [StringLength(3)]
        public string? JobDateType { get; set; }
        [Column("Job No Flag")]
        [StringLength(1)]
        public string? JobNoFlag { get; set; }
        [Column("Job Prefix 1")]
        [StringLength(3)]
        public string? JobPrefix1 { get; set; }
        [Column("Job Prefix 2")]
        [StringLength(3)]
        public string? JobPrefix2 { get; set; }
        [Column("Job Prefix 3")]
        [StringLength(3)]
        public string? JobPrefix3 { get; set; }
        [Column("Job Prefix 4")]
        [StringLength(3)]
        public string? JobPrefix4 { get; set; }
        [Column("Job Prefix 5")]
        [StringLength(3)]
        public string? JobPrefix5 { get; set; }
        [StringLength(1)]
        public string? K1 { get; set; }
        [StringLength(1)]
        public string? K2 { get; set; }
        [StringLength(1)]
        public string? K3 { get; set; }
        [StringLength(1)]
        public string? K4 { get; set; }
        [StringLength(1)]
        public string? K5 { get; set; }
        [StringLength(1)]
        public string? K6 { get; set; }
        [StringLength(1)]
        public string? K7 { get; set; }
        [StringLength(1)]
        public string? K8 { get; set; }
        [StringLength(1)]
        public string? K9 { get; set; }
        [Column("Last Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastPostDate { get; set; }
        [Column("Link To Ccn Flag")]
        [StringLength(1)]
        public string? LinkToCcnFlag { get; set; }
        [Column("Link To Market Flag")]
        [StringLength(1)]
        public string? LinkToMarketFlag { get; set; }
        [Column("Local City Code")]
        [StringLength(3)]
        public string? LocalCityCode { get; set; }
        [Column("Lock Confirm Booking Flag")]
        [StringLength(1)]
        public string? LockConfirmBookingFlag { get; set; }
        [Column("Long Sub House Suffix Flag")]
        [StringLength(1)]
        public string? LongSubHouseSuffixFlag { get; set; }
        [Column("Mandatory MAwb No Flag")]
        [StringLength(1)]
        public string? MandatoryMawbNoFlag { get; set; }
        [Column("Mth To Keep")]
        public int? MthToKeep { get; set; }
        [Column("Multi Booking Flag")]
        [StringLength(1)]
        public string? MultiBookingFlag { get; set; }
        [Column("Next Booking No")]
        [StringLength(10)]
        public string? NextBookingNo { get; set; }
        [Column("Next Cargo Trf Form No")]
        [StringLength(10)]
        public string? NextCargoTrfFormNo { get; set; }
        [Column("Next Collect No")]
        [StringLength(5)]
        public string? NextCollectNo { get; set; }
        [Column("Next Coload Job No")]
        [StringLength(7)]
        public string? NextColoadJobNo { get; set; }
        [Column("Next Consol Job No")]
        [StringLength(7)]
        public string? NextConsolJobNo { get; set; }
        [Column("Next Direct Job No")]
        [StringLength(7)]
        public string? NextDirectJobNo { get; set; }
        [Column("Next H Awb No")]
        [StringLength(7)]
        public string? NextHAwbNo { get; set; }
        [Column("Next Invoice No")]
        [StringLength(10)]
        public string? NextInvoiceNo { get; set; }
        [Column("Next Job No")]
        [StringLength(7)]
        public string? NextJobNo { get; set; }
        [Column("Next Job No Mth 01")]
        [StringLength(4)]
        public string? NextJobNoMth01 { get; set; }
        [Column("Next Job No Mth 02")]
        [StringLength(4)]
        public string? NextJobNoMth02 { get; set; }
        [Column("Next Job No Mth 03")]
        [StringLength(4)]
        public string? NextJobNoMth03 { get; set; }
        [Column("Next Job No Mth 04")]
        [StringLength(4)]
        public string? NextJobNoMth04 { get; set; }
        [Column("Next Job No Mth 05")]
        [StringLength(4)]
        public string? NextJobNoMth05 { get; set; }
        [Column("Next Job No Mth 06")]
        [StringLength(4)]
        public string? NextJobNoMth06 { get; set; }
        [Column("Next Job No Mth 07")]
        [StringLength(4)]
        public string? NextJobNoMth07 { get; set; }
        [Column("Next Job No Mth 08")]
        [StringLength(4)]
        public string? NextJobNoMth08 { get; set; }
        [Column("Next Job No Mth 09")]
        [StringLength(4)]
        public string? NextJobNoMth09 { get; set; }
        [Column("Next Job No Mth 10")]
        [StringLength(4)]
        public string? NextJobNoMth10 { get; set; }
        [Column("Next Job No Mth 11")]
        [StringLength(4)]
        public string? NextJobNoMth11 { get; set; }
        [Column("Next Job No Mth 12")]
        [StringLength(4)]
        public string? NextJobNoMth12 { get; set; }
        [Column("Next S MAwb Job No")]
        [StringLength(7)]
        public string? NextSMawbJobNo { get; set; }
        [Column("Next Trf Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NextTrfDate { get; set; }
        [Column("Online Booking Email")]
        [StringLength(250)]
        public string? OnlineBookingEmail { get; set; }
        [Column("Oth Chg By Agent Airline")]
        [StringLength(1)]
        public string? OthChgByAgentAirline { get; set; }
        [Column("Oth Item Code")]
        [StringLength(30)]
        public string? OthItemCode { get; set; }
        [Column("Other Charge Space")]
        public int? OtherChargeSpace { get; set; }
        [Column("Party Name Length")]
        public int? PartyNameLength { get; set; }
        [Column("Place Of Execute")]
        [StringLength(45)]
        public string? PlaceOfExecute { get; set; }
        [Column("Post By")]
        [StringLength(50)]
        public string? PostBy { get; set; }
        [Column("Print 2 Dimension Set On Right Flag")]
        [StringLength(1)]
        public string? Print2DimensionSetOnRightFlag { get; set; }
        [Column("Print 3 Dimension Set Flag")]
        [StringLength(1)]
        public string? Print3DimensionSetFlag { get; set; }
        [Column("Profit Share Item Code")]
        [StringLength(30)]
        public string? ProfitShareItemCode { get; set; }
        [Column("Prompt Update Final Dest To House Flag")]
        [StringLength(1)]
        public string? PromptUpdateFinalDestToHouseFlag { get; set; }
        [Column("Prompt Zero Pcs Flag")]
        [StringLength(1)]
        public string? PromptZeroPcsFlag { get; set; }
        [Column("Recompute Master Charge Weight Flag")]
        [StringLength(1)]
        public string? RecomputeMasterChargeWeightFlag { get; set; }
        [Column("Sender Tty Addr")]
        [StringLength(10)]
        public string? SenderTtyAddr { get; set; }
        [Column("Set Auto Compute Flag")]
        [StringLength(1)]
        public string? SetAutoComputeFlag { get; set; }
        [Column("Set Chg Wt Dec Place")]
        public int? SetChgWtDecPlace { get; set; }
        [Column("Set Commodity Length")]
        public int? SetCommodityLength { get; set; }
        [Column("Set Description Length")]
        public int? SetDescriptionLength { get; set; }
        [Column("Set Gross Wt Dec Place")]
        public int? SetGrossWtDecPlace { get; set; }
        [Column("Set User Charge Weight Flag")]
        [StringLength(1)]
        public string? SetUserChargeWeightFlag { get; set; }
        [Column("Set Vol Wt Dec Place")]
        public int? SetVolWtDecPlace { get; set; }
        [Column("Show Confirm Booking Flag")]
        [StringLength(1)]
        public string? ShowConfirmBookingFlag { get; set; }
        [Column("Show Gross Weight Flag")]
        [StringLength(1)]
        public string? ShowGrossWeightFlag { get; set; }
        [Column("SLAC Flag")]
        [StringLength(1)]
        public string? SlacFlag { get; set; }
        [Column("Total Dim Round Up Flag")]
        [StringLength(1)]
        public string? TotalDimRoundUpFlag { get; set; }
        [Column("Use M Awb Inventory Flag")]
        [StringLength(1)]
        public string? UseMAwbInventoryFlag { get; set; }
        [Column("Weight Raise For House And Direct Flag")]
        [StringLength(1)]
        public string? WeightRaiseForHouseAndDirectFlag { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
