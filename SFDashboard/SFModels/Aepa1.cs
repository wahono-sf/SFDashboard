using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aepa1")]
    public partial class Aepa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// The Business Party Code of the Company. Default as Shipper Code in the MAWB
        /// </summary>
        [StringLength(10)]
        public string? AgentCode { get; set; }
        /// <summary>
        /// Default the Name of the Company as Shipper Name in the MAWB
        /// </summary>
        [StringLength(80)]
        public string? AgentName { get; set; }
        /// <summary>
        /// The Account Code of the Company default as Shipper Account Code in MAWB
        /// </summary>
        [StringLength(15)]
        public string? AgentAccCode { get; set; }
        /// <summary>
        /// Default the Address 1 of the Company as Shipper Address 1 in the MAWB
        /// </summary>
        [StringLength(60)]
        public string? AgentAddress1 { get; set; }
        /// <summary>
        /// Default the Address 2 of the Company as Shipper Address 2 in the MAWB
        /// </summary>
        [StringLength(60)]
        public string? AgentAddress2 { get; set; }
        /// <summary>
        /// Default the Address 3 of the Company as Shipper Address 3 in the MAWB
        /// </summary>
        [StringLength(60)]
        public string? AgentAddress3 { get; set; }
        /// <summary>
        /// Default the Address 4 of the Company as Shipper Address 4 in the MAWB
        /// </summary>
        [StringLength(60)]
        public string? AgentAddress4 { get; set; }
        /// <summary>
        /// The IATA Code of the Company
        /// </summary>
        [StringLength(25)]
        public string? AgentIataCode { get; set; }
        /// <summary>
        /// Set filter Party Type for anat1 form to search Customer Code.
        /// </summary>
        [StringLength(3)]
        public string? AgentPartyType { get; set; }
        /// <summary>
        /// Allow HAWB No. to auto generate
        /// </summary>
        [Column("AutoHAwbNoFlag")]
        [StringLength(1)]
        public string? AutoHawbNoFlag { get; set; }
        /// <summary>
        /// Allow MAWB No. to auto generate
        /// </summary>
        [Column("AutoMAwbNoFlag")]
        [StringLength(1)]
        public string? AutoMawbNoFlag { get; set; }
        /// <summary>
        /// Default the Currency Code in the AWB
        /// </summary>
        [StringLength(3)]
        public string? AwbCurrCode { get; set; }
        [StringLength(30)]
        public string? AwbItemCode { get; set; }
        /// <summary>
        /// Default the Bank Acc Code to the Payment Voucher
        /// </summary>
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        /// <summary>
        /// Define the BankCode to default the BankCode in ivcr1_5
        /// </summary>
        [StringLength(10)]
        public string? BankCode { get; set; }
        /// <summary>
        /// Set as N, confirm booking don&apos;t generate job no
        /// </summary>
        [StringLength(1)]
        public string? BookingCreateJobNoFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(3)]
        public string? CargoManifestPrefix { get; set; }
        /// <summary>
        /// Default the Cash Acc Code to the Cash Receipt
        /// </summary>
        [StringLength(15)]
        public string? CashAccCode { get; set; }
        /// <summary>
        /// If set as N, it will not prompt the message and it will not change the Job No of the House
        /// </summary>
        [StringLength(1)]
        public string? ChangeMasterAwbNoFlag { get; set; }
        /// <summary>
        /// Set as Y, aeaw1 form tick auto-compute check box, the system should not recompute ChargeWt; Set as N should recompute.
        /// </summary>
        [StringLength(1)]
        public string? ChargeWtFlag { get; set; }
        /// <summary>
        /// If set as &apos;N&apos;, then it will disable the button New Booking on the Consol screen
        /// </summary>
        [StringLength(1)]
        public string? ConsolBookingFlag { get; set; }
        [StringLength(1)]
        public string? ConsolJobFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then it will default the check box &apos;Show Awb&apos; as ticked
        /// </summary>
        [StringLength(1)]
        public string? ConsolShowAwbFlag { get; set; }
        [StringLength(1)]
        public string? ConsolSubMasterFlag { get; set; }
        /// <summary>
        /// Pull the Rate from smct2 base on CourierItemCode to Csbk1’s Charge Rate
        /// </summary>
        [StringLength(30)]
        public string? CourierItemCode { get; set; }
        /// <summary>
        /// Define the Surcharge Rate to csbk1
        /// </summary>
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CourierSurchargeRate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CsrDate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(3)]
        public string? DcNotePrefix { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DcNoteSeqNo { get; set; }
        /// <summary>
        /// Default the Commoditiy Description when entering a new AWB
        /// </summary>
        [StringLength(50)]
        public string? DefaultCommodityDescription { get; set; }
        /// <summary>
        /// Default the Other Charge as P - Prepaid or C- Collect when entering a new AWB
        /// </summary>
        [StringLength(1)]
        public string? DefaultOther { get; set; }
        /// <summary>
        /// Default the Notify Party as SAME AS CONSIGNEE
        /// </summary>
        [StringLength(1)]
        public string? DefaultSameAsConsigneeFlag { get; set; }
        /// <summary>
        /// Default the Unit of Measurement Code when entering a new AWB. The code must be a valid code in UOM Table
        /// </summary>
        [StringLength(50)]
        public string? DefaultUomCode { get; set; }
        /// <summary>
        /// Default the Volume/Weight Ratio in Dimension tab in aebk1/aeaw1 when the Unit is &apos;CM&apos;. 
        /// e.g if set as &apos;5000&apos;, then the Volume/weight Ratio will default as &apos;5000&apos; for &apos;CM&apos;, and the Volumetric Weight = Total Dimension / 5000
        /// </summary>
        public short? DefaultVolumetricWeightRatio { get; set; }
        /// <summary>
        /// Default the Freight Charge as P - Prepaid or C- Collect when entering a new AWB
        /// </summary>
        [StringLength(1)]
        public string? DefaultWeightValue { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(45)]
        public string? DepartureAirportName { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(3)]
        public string? DeviceaddrCcn { get; set; }
        [StringLength(80)]
        public string? DgCargoRemark { get; set; }
        /// <summary>
        /// Define the symbol when load the dimension to Description &amp; Remarks on the Rate tab
        /// </summary>
        [StringLength(1)]
        public string? DimensionSeparation { get; set; }
        [StringLength(1)]
        public string? DirectHouseFlag { get; set; }
        /// <summary>
        /// Print to footer 1 of the Air Export related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        /// <summary>
        /// Print to footer 2 of the Air Export related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos; then show the &apos;ecFreight&apos; button instead of the button &apos;FHL Message&apos; and &apos;Fwb Message&apos;. when click the button &apos;ecFreight&apos;, just like click the button &apos;FHL Message&apos; and  &apos;Fwb Message&apos; to export data to the file at same time
        /// </summary>
        [StringLength(1)]
        public string? EcFreightFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then 1) show only those consignee under the same CityCode (base on the Destination City Code). 
        /// 2) After selecting the Consignee Code, system should be able to default the corresponding OverSea Agent Code (by comparing both the Destination City Code and Consignee Code).
        /// </summary>
        [StringLength(1)]
        public string? FilterConsigneeFlag { get; set; }
        /// <summary>
        /// Define the font type for the aeaw1.Description 1-12 and CommodityDescription 1-14
        /// </summary>
        [StringLength(50)]
        public string? FontType { get; set; }
        [StringLength(1)]
        public string? FrtAmtRoundUpFlag { get; set; }
        /// <summary>
        /// Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? FrtItemCode1 { get; set; }
        /// <summary>
        /// Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? FrtItemCode2 { get; set; }
        /// <summary>
        /// Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? FrtItemCode3 { get; set; }
        /// <summary>
        /// Default the Fuel Surcharges Item Code in Ivcr1. It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? FscItemCode { get; set; }
        /// <summary>
        /// J to default the HAWB same as Job No. H to create the HAWB no. base on the HAWB Prefix and Next HAWB No.
        /// </summary>
        [Column("HAwbNoFlag")]
        [StringLength(1)]
        public string? HawbNoFlag { get; set; }
        /// <summary>
        /// HAWB Prefix Format: YY,MM,DST
        /// </summary>
        [Column("HAwbPrefix")]
        [StringLength(11)]
        public string? HawbPrefix { get; set; }
        [StringLength(1)]
        public string? HideImportJobFlag { get; set; }
        [StringLength(1)]
        public string? IataRoundFlag { get; set; }
        /// <summary>
        /// Default the Insurance and Security Surcharges Item Code in Ivcr1. It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? IssItemCode { get; set; }
        /// <summary>
        /// Job Date is defined as FLD for First Flight Date or JCD Job Creation Date
        /// </summary>
        [StringLength(3)]
        public string? JobDateType { get; set; }
        /// <summary>
        /// Job running no. is created by C - Continously, M - Monthly, S - Shipment Type
        /// </summary>
        [StringLength(1)]
        public string? JobNoFlag { get; set; }
        /// <summary>
        /// Job Prefix 1 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix1 { get; set; }
        /// <summary>
        /// Job Prefix 2 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix2 { get; set; }
        /// <summary>
        /// Job Prefix 3 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix3 { get; set; }
        /// <summary>
        /// Job Prefix 4 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix4 { get; set; }
        /// <summary>
        /// Job Prefix 5 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix5 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K1
        /// </summary>
        [StringLength(1)]
        public string? K1 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K2
        /// </summary>
        [StringLength(1)]
        public string? K2 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K3
        /// </summary>
        [StringLength(1)]
        public string? K3 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K4
        /// </summary>
        [StringLength(1)]
        public string? K4 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K5
        /// </summary>
        [StringLength(1)]
        public string? K5 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K6
        /// </summary>
        [StringLength(1)]
        public string? K6 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K7
        /// </summary>
        [StringLength(1)]
        public string? K7 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K8
        /// </summary>
        [StringLength(1)]
        public string? K8 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K9
        /// </summary>
        [StringLength(1)]
        public string? K9 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastPostDate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? LinkToCcnFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? LinkToMarketFlag { get; set; }
        /// <summary>
        /// Default the Airport Code to Airport of Departure. It must be a valid Airport Code
        /// </summary>
        [StringLength(3)]
        public string? LocalCityCode { get; set; }
        [StringLength(1)]
        public string? LockConfirmBookingFlag { get; set; }
        [StringLength(1)]
        public string? LongSubHouseSuffixFlag { get; set; }
        [StringLength(1)]
        public string? MandatoryMawbNoFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        public int? MthToKeep { get; set; }
        /// <summary>
        /// Allow the Booking entry in multiple AWB
        /// </summary>
        [StringLength(1)]
        public string? MultiBookingFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? NextBookingNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? NextCargoTrfFormNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? NextCollectNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(7)]
        public string? NextColoadJobNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(7)]
        public string? NextConsolJobNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(7)]
        public string? NextDirectJobNo { get; set; }
        /// <summary>
        /// Next No. to create the HAWB
        /// </summary>
        [Column("NextHAwbNo")]
        [StringLength(7)]
        public string? NextHawbNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo { get; set; }
        /// <summary>
        /// Next Job No when Job No Flag is set as C
        /// </summary>
        [StringLength(7)]
        public string? NextJobNo { get; set; }
        /// <summary>
        /// Next Job No for Mth 01 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth01 { get; set; }
        /// <summary>
        /// Next Job No for Mth 02 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth02 { get; set; }
        /// <summary>
        /// Next Job No for Mth 03 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth03 { get; set; }
        /// <summary>
        /// Next Job No for Mth 04 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth04 { get; set; }
        /// <summary>
        /// Next Job No for Mth 05 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth05 { get; set; }
        /// <summary>
        /// Next Job No for Mth 06 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth06 { get; set; }
        /// <summary>
        /// Next Job No for Mth 07 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth07 { get; set; }
        /// <summary>
        /// Next Job No for Mth 08 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth08 { get; set; }
        /// <summary>
        /// Next Job No for Mth 09 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth09 { get; set; }
        /// <summary>
        /// Next Job No for Mth 10 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth10 { get; set; }
        /// <summary>
        /// Next Job No for Mth 11 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth11 { get; set; }
        /// <summary>
        /// Next Job No for Mth 12 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth12 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("NextSMAwbJobNo")]
        [StringLength(7)]
        public string? NextSmawbJobNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? NextTrfDate { get; set; }
        [StringLength(250)]
        public string? OnlineBookingEmail { get; set; }
        [StringLength(30)]
        public string? OthItemCode { get; set; }
        [StringLength(1)]
        public string? OthChgByAgentAirline { get; set; }
        /// <summary>
        /// Define the spacing between each charge on the Other Charges under the Charge Info tab in aeaw1
        /// </summary>
        public int? OtherChargeSpace { get; set; }
        /// <summary>
        /// Define the space between each charge in Charges Tab in aeaw1
        /// </summary>
        public int? PartyNameLength { get; set; }
        /// <summary>
        /// The place of the AWB executed
        /// </summary>
        [StringLength(45)]
        public string? PlaceOfExecute { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? PostBy { get; set; }
        /// <summary>
        /// Define the spacing between each charge for Other Charges on the Charge Info tab in aeaw1 form
        /// </summary>
        [StringLength(1)]
        public string? Print2DimensionSetOnRightFlag { get; set; }
        /// <summary>
        /// set as &apos;Y&apos; to default the &apos;Print 3 Dimension Set&apos; check-box as ticked in Load Dimension screen
        /// </summary>
        [StringLength(1)]
        public string? Print3DimensionSetFlag { get; set; }
        [StringLength(30)]
        public string? ProfitShareItemCode { get; set; }
        [StringLength(1)]
        public string? PromptUpdateFinalDestToHseFlag { get; set; }
        /// <summary>
        /// Prompt user when Pcs is zero
        /// </summary>
        [StringLength(1)]
        public string? PromptZeroPcsFlag { get; set; }
        [StringLength(1)]
        public string? RecomputeMasterChgWtFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? SenderTtyAddr { get; set; }
        /// <summary>
        /// Create new aeaw1 record, default if Auto Compute is ticked
        /// </summary>
        [StringLength(1)]
        public string? SetAutoComputeFlag { get; set; }
        /// <summary>
        /// Set the decimal place of the Charge Weight
        /// </summary>
        public int? SetChgWtDecPlace { get; set; }
        /// <summary>
        /// Set the Commodity Description Length
        /// </summary>
        public int? SetCommodityLength { get; set; }
        public int? SetDescriptionLength { get; set; }
        /// <summary>
        /// Set the decimal place of the Gross Weight
        /// </summary>
        public int? SetGrossWtDecPlace { get; set; }
        [StringLength(1)]
        public string? SetUserChgWtFlag { get; set; }
        /// <summary>
        /// Set the decimal place of the Volumetric Weight
        /// </summary>
        public int? SetVolWtDecPlace { get; set; }
        [StringLength(1)]
        public string? ShowConfirmBookingFlag { get; set; }
        /// <summary>
        /// Show the Gross Weight column in Dimension screen
        /// </summary>
        [StringLength(1)]
        public string? ShowGrossWeightFlag { get; set; }
        /// <summary>
        /// If set as Y, then the SLAC Qty should be mandatory
        /// </summary>
        [StringLength(1)]
        public string? SlacFlag { get; set; }
        /// <summary>
        /// To round up the total dimension.If set Y, e.g 12.1 will round up to 13.0, if set T, e.g 12.1 will round up to 12.5. Recommend to set as Y
        /// </summary>
        [StringLength(1)]
        public string? TotalDimRoundUpFlag { get; set; }
        /// <summary>
        /// Use the AWB Inventory to enter new AWB instead of auto-update the new AWB no to the AWB inventory table.
        /// </summary>
        [Column("UseMAwbInventoryFlag")]
        [StringLength(1)]
        public string? UseMawbInventoryFlag { get; set; }
        [StringLength(1)]
        public string? WeightRaiseForHouseAndDirectFlag { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
