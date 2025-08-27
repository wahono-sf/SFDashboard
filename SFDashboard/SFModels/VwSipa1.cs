using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSipa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Auto Bl No Flag")]
        [StringLength(1)]
        public string? AutoBlNoFlag { get; set; }
        [Column("Auto Master Flag")]
        [StringLength(1)]
        public string? AutoMasterFlag { get; set; }
        [Column("Auto Update Export Booking Flag")]
        [StringLength(1)]
        public string? AutoUpdateExportBookingFlag { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Bl Curr Code")]
        [StringLength(3)]
        public string? BlCurrCode { get; set; }
        [Column("Bl Issue Place")]
        [StringLength(45)]
        public string? BlIssuePlace { get; set; }
        [Column("Cash Acc Code")]
        [StringLength(15)]
        public string? CashAccCode { get; set; }
        [Column("CFS Removal Charge Code")]
        [StringLength(30)]
        public string? CfsRemovalChargeCode { get; set; }
        [Column("CFS Storage Charge Code")]
        [StringLength(30)]
        public string? CfsStorageChargeCode { get; set; }
        [Column("CFS Upload Flag")]
        [StringLength(1)]
        public string? CfsUploadFlag { get; set; }
        [Column("Change Master Job No Flag")]
        [StringLength(1)]
        public string? ChangeMasterJobNoFlag { get; set; }
        [Column("Charge Collect Item Code")]
        [StringLength(30)]
        public string? ChargeCollectItemCode { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("City Name")]
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column("Commodity Description Row")]
        public int? CommodityDescriptionRow { get; set; }
        [Column("Consol Transport Company Code")]
        [StringLength(10)]
        public string? ConsolTransportCompanyCode { get; set; }
        [Column("Container No Blank Flag")]
        [StringLength(1)]
        public string? ContainerNoBlankFlag { get; set; }
        [Column("Copy Consol Job Type")]
        [StringLength(10)]
        public string? CopyConsolJobType { get; set; }
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
        [Column("Default Consignee")]
        [StringLength(1)]
        public string? DefaultConsignee { get; set; }
        [Column("Default Customer Code")]
        [StringLength(10)]
        public string? DefaultCustomerCode { get; set; }
        [Column("Default Document")]
        [StringLength(2)]
        public string? DefaultDocument { get; set; }
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
        [Column("Edit Freight Collect Flag")]
        [StringLength(1)]
        public string? EditFreightCollectFlag { get; set; }
        [Column("Fcl Transport Company Code")]
        [StringLength(10)]
        public string? FclTransportCompanyCode { get; set; }
        [Column("Free Storage Day")]
        public int? FreeStorageDay { get; set; }
        [Column("Freight Item Code")]
        [StringLength(30)]
        public string? FreightItemCode { get; set; }
        [Column("Freight Collect Item Code")]
        [StringLength(30)]
        public string? FreightCollectItemCode { get; set; }
        [Column("Gate Charge Code")]
        [StringLength(30)]
        public string? GateChargeCode { get; set; }
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
        [Column("Hide Export Bl Surrendered Flag")]
        [StringLength(1)]
        public string? HideExportBlSurrenderedFlag { get; set; }
        [Column("Hide T/S Button Flag")]
        [StringLength(1)]
        public string? HideTSButtonFlag { get; set; }
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
        [Column("Last Invoice Trf Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastInvoiceTrfDate { get; set; }
        [Column("Last Job Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastJobPostDate { get; set; }
        [Column("Lock Close Job Permit Flag")]
        [StringLength(1)]
        public string? LockCloseJobPermitFlag { get; set; }
        [Column("Lock Freight Collect Flag")]
        [StringLength(1)]
        public string? LockFreightCollectFlag { get; set; }
        [Column("Lock Transhipment Rate Flag")]
        [StringLength(1)]
        public string? LockTranshipmentRateFlag { get; set; }
        [Column("Lock Ts Job Export Close Flag")]
        [StringLength(1)]
        public string? LockTsJobExportCloseFlag { get; set; }
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
        [Column("Nomination Salesman Code")]
        [StringLength(10)]
        public string? NominationSalesmanCode { get; set; }
        [Column("Order Item Code")]
        [StringLength(30)]
        public string? OrderItemCode { get; set; }
        [Column("Permit Name")]
        [StringLength(50)]
        public string? PermitName { get; set; }
        [Column("Prompt Transhipment Info Flag")]
        [StringLength(1)]
        public string? PromptTranshipmentInfoFlag { get; set; }
        [Column("Rebate Item Code")]
        [StringLength(30)]
        public string? RebateItemCode { get; set; }
        [Column("Set Address Length")]
        public int? SetAddressLength { get; set; }
        [Column("Set Description Row")]
        public int? SetDescriptionRow { get; set; }
        [Column("Set Description Length")]
        public int? SetDescriptionLength { get; set; }
        [Column("Set Marks Length")]
        public int? SetMarksLength { get; set; }
        [Column("Set Name Length")]
        public int? SetNameLength { get; set; }
        [Column("Show Charge Weight Flag")]
        [StringLength(1)]
        public string? ShowChargeWeightFlag { get; set; }
        [Column("Show Consol Column")]
        [StringLength(50)]
        public string? ShowConsolColumn { get; set; }
        [Column("Show Delivery Date Flag")]
        [StringLength(1)]
        public string? ShowDeliveryDateFlag { get; set; }
        [Column("Show DG Cargo Tab Flag")]
        [StringLength(1)]
        public string? ShowDgCargoTabFlag { get; set; }
        [Column("Show Empty Date Flag")]
        [StringLength(1)]
        public string? ShowEmptyDateFlag { get; set; }
        [Column("Show Export Info Flag")]
        [StringLength(1)]
        public string? ShowExportInfoFlag { get; set; }
        [Column("Show Request Date Flag")]
        [StringLength(1)]
        public string? ShowRequestDateFlag { get; set; }
        [Column("Show Source Job Doc Flag")]
        [StringLength(1)]
        public string? ShowSourceJobDocFlag { get; set; }
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
        [Column("Sub House Copy Flag")]
        [StringLength(1)]
        public string? SubHouseCopyFlag { get; set; }
        [Column("Sub House Job No Flag")]
        [StringLength(1)]
        public string? SubHouseJobNoFlag { get; set; }
        [Column("Transhipment Booking No Flag")]
        [StringLength(1)]
        public string? TranshipmentBookingNoFlag { get; set; }
        [Column("Transhipment Booking Prefix")]
        [StringLength(20)]
        public string? TranshipmentBookingPrefix { get; set; }
        [Column("Transhipment Charge Code")]
        [StringLength(30)]
        public string? TranshipmentChargeCode { get; set; }
        [Column("Transhipment Hide Tab Flag")]
        [StringLength(1)]
        public string? TranshipmentHideTabFlag { get; set; }
        [Column("Transhipment Item Code")]
        [StringLength(30)]
        public string? TranshipmentItemCode { get; set; }
        [Column("Transhipment Item Description")]
        [StringLength(50)]
        public string? TranshipmentItemDescription { get; set; }
        [Column("Ts Frt Collect Flag")]
        [StringLength(1)]
        public string? TsFrtCollectFlag { get; set; }
        [Column("Upper Case Flag")]
        [StringLength(1)]
        public string? UpperCaseFlag { get; set; }
        [Column("View Export Consol Booking Flag")]
        [StringLength(1)]
        public string? ViewExportConsolBookingFlag { get; set; }
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
