using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSepa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Append Booking No Flag")]
        [StringLength(1)]
        public string? AppendBookingNoFlag { get; set; }
        [Column("Ata Name")]
        [StringLength(10)]
        public string? AtaName { get; set; }
        [Column("Auto Attach Flag")]
        [StringLength(1)]
        public string? AutoAttachFlag { get; set; }
        [Column("Auto Update Bl Date Flag")]
        [StringLength(1)]
        public string? AutoUpdateBlDateFlag { get; set; }
        [Column("Auto Update Dest Flag")]
        [StringLength(1)]
        public string? AutoUpdateDestFlag { get; set; }
        [Column("Auto Update Ucr No Flag")]
        [StringLength(1)]
        public string? AutoUpdateUcrNoFlag { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Bl Charge Copy Job Costing")]
        [StringLength(50)]
        public string? BlChargeCopyJobCosting { get; set; }
        [Column("Bl Curr Code")]
        [StringLength(3)]
        public string? BlCurrCode { get; set; }
        [Column("Bl Dest Code Position")]
        [StringLength(2)]
        public string? BlDestCodePosition { get; set; }
        [Column("Bl Issue Place")]
        [StringLength(45)]
        public string? BlIssuePlace { get; set; }
        [Column("Block Create Booking Flag")]
        [StringLength(1)]
        public string? BlockCreateBookingFlag { get; set; }
        [Column("Bl Surrender Flag")]
        [StringLength(1)]
        public string? BlSurrenderFlag { get; set; }
        [Column("Booking Confirm Email Address")]
        [StringLength(255)]
        public string? BookingConfirmEmailAddress { get; set; }
        [Column("Booking Confirm Report Name")]
        [StringLength(50)]
        public string? BookingConfirmReportName { get; set; }
        [Column("Booking Create Job No Flag")]
        [StringLength(1)]
        public string? BookingCreateJobNoFlag { get; set; }
        [Column("Booking Dest Code Position")]
        [StringLength(2)]
        public string? BookingDestCodePosition { get; set; }
        [Column("Booking No Flag")]
        [StringLength(1)]
        public string? BookingNoFlag { get; set; }
        [Column("Booking Term And Condition")]
        [StringLength(3000)]
        public string? BookingTermAndCondition { get; set; }
        [Column("Cargo Load Report 1")]
        [StringLength(50)]
        public string? CargoLoadReport1 { get; set; }
        [Column("Cargo Load Report 2")]
        [StringLength(50)]
        public string? CargoLoadReport2 { get; set; }
        [Column("Cargo Load Report Label 1")]
        [StringLength(50)]
        public string? CargoLoadReportLabel1 { get; set; }
        [Column("Cargo Load Report Label 2")]
        [StringLength(50)]
        public string? CargoLoadReportLabel2 { get; set; }
        [Column("Cash Acc Code")]
        [StringLength(15)]
        public string? CashAccCode { get; set; }
        [Column("Change Booking No Flag")]
        [StringLength(1)]
        public string? ChangeBookingNoFlag { get; set; }
        [Column("Change Master Job No Flag")]
        [StringLength(1)]
        public string? ChangeMasterJobNoFlag { get; set; }
        [Column("Change Master Update Flag")]
        [StringLength(1)]
        public string? ChangeMasterUpdateFlag { get; set; }
        [Column("Change Schedule")]
        [StringLength(1)]
        public string? ChangeSchedule { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("City Name")]
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column("Close Consol Right")]
        [StringLength(1)]
        public string? CloseConsolRight { get; set; }
        [Column("Close Schedule Day")]
        public short? CloseScheduleDay { get; set; }
        [Column("Cls Consol Booking Access Right")]
        [StringLength(1)]
        public string? ClsConsolBookingAccessRight { get; set; }
        [Column("Commodity Description Row")]
        public int? CommodityDescriptionRow { get; set; }
        [Column("Company Code")]
        [StringLength(10)]
        public string? CompanyCode { get; set; }
        [Column("Company Name")]
        [StringLength(80)]
        public string? CompanyName { get; set; }
        [Column("Company Address 1")]
        [StringLength(60)]
        public string? CompanyAddress1 { get; set; }
        [Column("Company Address 2")]
        [StringLength(60)]
        public string? CompanyAddress2 { get; set; }
        [Column("Company Address 3")]
        [StringLength(60)]
        public string? CompanyAddress3 { get; set; }
        [Column("Company Address 4")]
        [StringLength(60)]
        public string? CompanyAddress4 { get; set; }
        [Column("Confirm Booking Remark")]
        [StringLength(100)]
        public string? ConfirmBookingRemark { get; set; }
        [Column("Confirm Consol Booking Flag")]
        [StringLength(1)]
        public string? ConfirmConsolBookingFlag { get; set; }
        [Column("Consol Bl Flag")]
        [StringLength(1)]
        public string? ConsolBlFlag { get; set; }
        [Column("Consol Booking Job Type")]
        [StringLength(200)]
        public string? ConsolBookingJobType { get; set; }
        [Column("Consol Dest Eta Flag")]
        [StringLength(1)]
        public string? ConsolDestEtaFlag { get; set; }
        [Column("Consol Job Flag")]
        [StringLength(1)]
        public string? ConsolJobFlag { get; set; }
        [Column("Consol Sub Master Flag")]
        [StringLength(1)]
        public string? ConsolSubMasterFlag { get; set; }
        [Column("Container Main Database U R L")]
        [StringLength(200)]
        public string? ContainerMainDatabaseURL { get; set; }
        [Column("Container Type 1")]
        [StringLength(5)]
        public string? ContainerType1 { get; set; }
        [Column("Container Type 2")]
        [StringLength(5)]
        public string? ContainerType2 { get; set; }
        [Column("Container Type 3")]
        [StringLength(5)]
        public string? ContainerType3 { get; set; }
        [Column("Container Type 4")]
        [StringLength(5)]
        public string? ContainerType4 { get; set; }
        [Column("Copy Booking Flag")]
        [StringLength(1)]
        public string? CopyBookingFlag { get; set; }
        [Column("Copy Consol Job Type")]
        [StringLength(10)]
        public string? CopyConsolJobType { get; set; }
        [Column("Copy Container Description")]
        [StringLength(25)]
        public string? CopyContainerDescription { get; set; }
        [Column("Copy Container Flag")]
        [StringLength(1)]
        public string? CopyContainerFlag { get; set; }
        [Column("Copy Master House Flag")]
        [StringLength(1)]
        public string? CopyMasterHouseFlag { get; set; }
        [Column("Customer Party Type")]
        [StringLength(50)]
        public string? CustomerPartyType { get; set; }
        [Column("Default Cargo Type Flag")]
        [StringLength(1)]
        public string? DefaultCargoTypeFlag { get; set; }
        [Column("Default Close Date")]
        public int? DefaultCloseDate { get; set; }
        [Column("Default Close Date Type")]
        [StringLength(10)]
        public string? DefaultCloseDateType { get; set; }
        [Column("Default Close Time")]
        [StringLength(5)]
        public string? DefaultCloseTime { get; set; }
        [Column("Default Document")]
        [StringLength(2)]
        public string? DefaultDocument { get; set; }
        [Column("Default Eta Flag")]
        [StringLength(1)]
        public string? DefaultEtaFlag { get; set; }
        [Column("Default Package")]
        [StringLength(3)]
        public string? DefaultPackage { get; set; }
        [Column("Default Transport Company Code")]
        [StringLength(10)]
        public string? DefaultTransportCompanyCode { get; set; }
        [Column("Default Vendor Name Flag")]
        [StringLength(1)]
        public string? DefaultVendorNameFlag { get; set; }
        [Column("Direct House Flag")]
        [StringLength(1)]
        public string? DirectHouseFlag { get; set; }
        [Column("Document Footer 1")]
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        [Column("Document Footer 2")]
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        [Column("Draft O B L No Flag")]
        [StringLength(1)]
        public string? DraftOBLNoFlag { get; set; }
        [Column("Draft O B L No Prefix")]
        [StringLength(11)]
        public string? DraftOBLNoPrefix { get; set; }
        [Column("Eta Day")]
        public short? EtaDay { get; set; }
        [Column("Etd Flag")]
        [StringLength(1)]
        public string? EtdFlag { get; set; }
        [Column("Fcl Cargo Description")]
        [StringLength(50)]
        public string? FclCargoDescription { get; set; }
        [Column("Font Type")]
        [StringLength(50)]
        public string? FontType { get; set; }
        [Column("Free Day Email")]
        [StringLength(255)]
        public string? FreeDayEmail { get; set; }
        [Column("Free Days Report Name")]
        [StringLength(50)]
        public string? FreeDaysReportName { get; set; }
        [Column("Free Storage Day")]
        public int? FreeStorageDay { get; set; }
        [Column("Freight Item Code")]
        [StringLength(30)]
        public string? FreightItemCode { get; set; }
        [Column("Haulier Report 1")]
        [StringLength(50)]
        public string? HaulierReport1 { get; set; }
        [Column("Haulier Report 2")]
        [StringLength(50)]
        public string? HaulierReport2 { get; set; }
        [Column("Haulier Report Label 1")]
        [StringLength(50)]
        public string? HaulierReportLabel1 { get; set; }
        [Column("Haulier Report Label 2")]
        [StringLength(50)]
        public string? HaulierReportLabel2 { get; set; }
        [Column("H Bl No Flag")]
        [StringLength(1)]
        public string? HBlNoFlag { get; set; }
        [Column("H Bl Prefix")]
        [StringLength(11)]
        public string? HBlPrefix { get; set; }
        [Column("H Bl Suffix")]
        [StringLength(20)]
        public string? HBlSuffix { get; set; }
        [Column("Hide Bl Column Flag")]
        [StringLength(1)]
        public string? HideBlColumnFlag { get; set; }
        [Column("Hide Booking Check Box Flag")]
        [StringLength(1)]
        public string? HideBookingCheckBoxFlag { get; set; }
        [Column("Hide Change Bkg No Flag")]
        [StringLength(1)]
        public string? HideChangeBkgNoFlag { get; set; }
        [Column("Hide Confirm Message Flag")]
        [StringLength(1)]
        public string? HideConfirmMessageFlag { get; set; }
        [Column("Hide Country Of Origin Flag")]
        [StringLength(1)]
        public string? HideCountryOfOriginFlag { get; set; }
        [Column("Hide Import Job Flag")]
        [StringLength(1)]
        public string? HideImportJobFlag { get; set; }
        [Column("Hide Original BL Flag")]
        [StringLength(1)]
        public string? HideOriginalBlFlag { get; set; }
        [Column("Hide Update BL Flag")]
        [StringLength(1)]
        public string? HideUpdateBlFlag { get; set; }
        [Column("House Seq No Flag")]
        [StringLength(1)]
        public string? HouseSeqNoFlag { get; set; }
        [Column("Invoice Trf By")]
        [StringLength(50)]
        public string? InvoiceTrfBy { get; set; }
        [Column("Job Date Type")]
        [StringLength(3)]
        public string? JobDateType { get; set; }
        [Column("Job Format Type")]
        [StringLength(1)]
        public string? JobFormatType { get; set; }
        [Column("Job No Format")]
        [StringLength(255)]
        public string? JobNoFormat { get; set; }
        [Column("Job No Flag")]
        [StringLength(1)]
        public string? JobNoFlag { get; set; }
        [Column("Job Post By")]
        [StringLength(50)]
        public string? JobPostBy { get; set; }
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
        [Column("Keep Combine Booking Flag")]
        [StringLength(1)]
        public string? KeepCombineBookingFlag { get; set; }
        [Column("Last Invoice Transfer Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastInvoiceTransferDate { get; set; }
        [Column("Last Job Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastJobPostDate { get; set; }
        [Column("Lock Close Job Permit Flag")]
        [StringLength(1)]
        public string? LockCloseJobPermitFlag { get; set; }
        [Column("Lock Confirm Booking Flag")]
        [StringLength(1)]
        public string? LockConfirmBookingFlag { get; set; }
        [Column("Lock Freight Collect Flag")]
        [StringLength(1)]
        public string? LockFreightCollectFlag { get; set; }
        [Column("Long Sub House Suffix Flag")]
        [StringLength(1)]
        public string? LongSubHouseSuffixFlag { get; set; }
        [Column("Manual Booking No Flag")]
        [StringLength(1)]
        public string? ManualBookingNoFlag { get; set; }
        [Column("Manual Voyage ID Flag")]
        [StringLength(1)]
        public string? ManualVoyageIdFlag { get; set; }
        [Column("Min Charge Weight Flag")]
        [StringLength(1)]
        public string? MinChargeWeightFlag { get; set; }
        [Column("Next Consol Job No")]
        [StringLength(7)]
        public string? NextConsolJobNo { get; set; }
        [Column("Next Direct Job No")]
        [StringLength(7)]
        public string? NextDirectJobNo { get; set; }
        [Column("Next Draft O B L No")]
        [StringLength(7)]
        public string? NextDraftOBLNo { get; set; }
        [Column("Next H Bl No")]
        [StringLength(7)]
        public string? NextHBlNo { get; set; }
        [Column("Next Job No")]
        [StringLength(7)]
        public string? NextJobNo { get; set; }
        [Column("Next Job No Mth 01")]
        [StringLength(7)]
        public string? NextJobNoMth01 { get; set; }
        [Column("Next Job No Mth 02")]
        [StringLength(7)]
        public string? NextJobNoMth02 { get; set; }
        [Column("Next Job No Mth 03")]
        [StringLength(7)]
        public string? NextJobNoMth03 { get; set; }
        [Column("Next Job No Mth 04")]
        [StringLength(7)]
        public string? NextJobNoMth04 { get; set; }
        [Column("Next Job No Mth 05")]
        [StringLength(7)]
        public string? NextJobNoMth05 { get; set; }
        [Column("Next Job No Mth 06")]
        [StringLength(7)]
        public string? NextJobNoMth06 { get; set; }
        [Column("Next Job No Mth 07")]
        [StringLength(7)]
        public string? NextJobNoMth07 { get; set; }
        [Column("Next Job No Mth 08")]
        [StringLength(7)]
        public string? NextJobNoMth08 { get; set; }
        [Column("Next Job No Mth 09")]
        [StringLength(7)]
        public string? NextJobNoMth09 { get; set; }
        [Column("Next Job No Mth 10")]
        [StringLength(7)]
        public string? NextJobNoMth10 { get; set; }
        [Column("Next Job No Mth 11")]
        [StringLength(7)]
        public string? NextJobNoMth11 { get; set; }
        [Column("Next Job No Mth 12")]
        [StringLength(7)]
        public string? NextJobNoMth12 { get; set; }
        [Column("Nomination Item Code")]
        [StringLength(30)]
        public string? NominationItemCode { get; set; }
        [Column("Nomination Salesman Code")]
        [StringLength(10)]
        public string? NominationSalesmanCode { get; set; }
        [Column("Online Booking Email")]
        [StringLength(250)]
        public string? OnlineBookingEmail { get; set; }
        [Column("Permit Name")]
        [StringLength(50)]
        public string? PermitName { get; set; }
        [Column("Profit Share Item Code")]
        [StringLength(30)]
        public string? ProfitShareItemCode { get; set; }
        [Column("Prompt Master Info Flag")]
        [StringLength(1)]
        public string? PromptMasterInfoFlag { get; set; }
        [Column("Rebate Item Code")]
        [StringLength(30)]
        public string? RebateItemCode { get; set; }
        [Column("Release Order Job Type")]
        [StringLength(200)]
        public string? ReleaseOrderJobType { get; set; }
        [Column("Release Order No Field")]
        [StringLength(50)]
        public string? ReleaseOrderNoField { get; set; }
        [Column("Said To Contain")]
        [StringLength(50)]
        public string? SaidToContain { get; set; }
        [Column("Set Description Length")]
        public int? SetDescriptionLength { get; set; }
        [Column("Set Description 01 Length")]
        public int? SetDescription01Length { get; set; }
        [Column("Set Description 02 Length")]
        public int? SetDescription02Length { get; set; }
        [Column("Set Description Row")]
        public int? SetDescriptionRow { get; set; }
        [Column("Set Marks Length")]
        public int? SetMarksLength { get; set; }
        [Column("Set Mark Row")]
        public int? SetMarkRow { get; set; }
        [Column("Show Actual Booking No")]
        [StringLength(1)]
        public string? ShowActualBookingNo { get; set; }
        [Column("Show Approve Free Days")]
        [StringLength(1)]
        public string? ShowApproveFreeDays { get; set; }
        [Column("Show Bl Country Code Flag")]
        [StringLength(1)]
        public string? ShowBlCountryCodeFlag { get; set; }
        [Column("Show Bl Flag")]
        [StringLength(1)]
        public string? ShowBlFlag { get; set; }
        [Column("Show Booking Container Flag")]
        [StringLength(1)]
        public string? ShowBookingContainerFlag { get; set; }
        [Column("Show Booking In Consol Flag")]
        [StringLength(10)]
        public string? ShowBookingInConsolFlag { get; set; }
        [Column("Show Charge Weight Flag")]
        [StringLength(1)]
        public string? ShowChargeWeightFlag { get; set; }
        [Column("Show Confirm Booking Flag")]
        [StringLength(1)]
        public string? ShowConfirmBookingFlag { get; set; }
        [Column("Show Consol Column")]
        [StringLength(50)]
        public string? ShowConsolColumn { get; set; }
        [Column("Show DG Cargo Consol Flag")]
        [StringLength(1)]
        public string? ShowDgCargoConsolFlag { get; set; }
        [Column("Show DG Cargo Tab Flag")]
        [StringLength(1)]
        public string? ShowDgCargoTabFlag { get; set; }
        [Column("Show Empty Date Flag")]
        [StringLength(1)]
        public string? ShowEmptyDateFlag { get; set; }
        [Column("Show Laden Date Flag")]
        [StringLength(1)]
        public string? ShowLadenDateFlag { get; set; }
        [Column("Show Loose Qty Flag")]
        [StringLength(1)]
        public string? ShowLooseQtyFlag { get; set; }
        [Column("Show Multiple Pickup Flag")]
        [StringLength(1)]
        public string? ShowMultiplePickupFlag { get; set; }
        [Column("Show Print Flag")]
        [StringLength(1)]
        public string? ShowPrintFlag { get; set; }
        [Column("Show Time For Laden Date Flag")]
        [StringLength(1)]
        public string? ShowTimeForLadenDateFlag { get; set; }
        [Column("Show Total Container")]
        [StringLength(5)]
        public string? ShowTotalContainer { get; set; }
        [Column("Show Trucking Date Flag")]
        [StringLength(1)]
        public string? ShowTruckingDateFlag { get; set; }
        [Column("Show Truck Out Date Flag")]
        [StringLength(1)]
        public string? ShowTruckOutDateFlag { get; set; }
        [Column("Storage Charge Code")]
        [StringLength(30)]
        public string? StorageChargeCode { get; set; }
        [Column("Sub House Copy Party Flag")]
        [StringLength(1)]
        public string? SubHouseCopyPartyFlag { get; set; }
        [Column("Sub House Job No Flag")]
        [StringLength(1)]
        public string? SubHouseJobNoFlag { get; set; }
        [Column("Transhipment Rate Flag")]
        [StringLength(1)]
        public string? TranshipmentRateFlag { get; set; }
        [Column("Ts Booking Customer Name")]
        [StringLength(50)]
        public string? TsBookingCustomerName { get; set; }
        [Column("Unconfirm Booking Flag")]
        [StringLength(1)]
        public string? UnconfirmBookingFlag { get; set; }
        [Column("Unlock BL Surrender Flag")]
        [StringLength(1)]
        public string? UnlockBlSurrenderFlag { get; set; }
        [Column("Unlock Booking Remark Flag")]
        [StringLength(1)]
        public string? UnlockBookingRemarkFlag { get; set; }
        [Column("Unlock Delivery Info Flag")]
        [StringLength(1)]
        public string? UnlockDeliveryInfoFlag { get; set; }
        [Column("Unlock Master Job No Flag")]
        [StringLength(1)]
        public string? UnlockMasterJobNoFlag { get; set; }
        [Column("Update Booking Container Flag")]
        [StringLength(1)]
        public string? UpdateBookingContainerFlag { get; set; }
        [Column("Update From Sub House")]
        [StringLength(1)]
        public string? UpdateFromSubHouse { get; set; }
        [Column("Update Master Container Flag")]
        [StringLength(1)]
        public string? UpdateMasterContainerFlag { get; set; }
        [Column("Upd Booking To Bl Flag")]
        [StringLength(1)]
        public string? UpdBookingToBlFlag { get; set; }
        [Column("Upper Case Flag")]
        [StringLength(1)]
        public string? UpperCaseFlag { get; set; }
        [Column("Voyage Job No Flag")]
        [StringLength(1)]
        public string? VoyageJobNoFlag { get; set; }
        [Column("Voyage No Schedule Flag")]
        [StringLength(1)]
        public string? VoyageNoScheduleFlag { get; set; }
        [Column("Warehouse Code")]
        [StringLength(10)]
        public string? WarehouseCode { get; set; }
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
