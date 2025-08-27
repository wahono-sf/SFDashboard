using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sipa1")]
    public partial class Sipa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [StringLength(1)]
        public string? AutoBlNoFlag { get; set; }
        /// <summary>
        /// If set as N, when create new House Shipment that does not have a Master Job No, then will not insert Master Job rcord into sibl1
        /// </summary>
        [StringLength(1)]
        public string? AutoMasterFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, the Transhipment =Y in sibl1 it will auto update to sebk1 base on the importjobno in sebk1
        /// </summary>
        [StringLength(1)]
        public string? AutoUpdateExportBookingFlag { get; set; }
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
        /// Default the Currency Code when entering a new B/L
        /// </summary>
        [StringLength(3)]
        public string? BlCurrCode { get; set; }
        /// <summary>
        /// Default the Place of issue When entering a new B/L
        /// </summary>
        [StringLength(45)]
        public string? BlIssuePlace { get; set; }
        /// <summary>
        /// Default the Cash Acc Code to the Cash Receipt
        /// </summary>
        [StringLength(15)]
        public string? CashAccCode { get; set; }
        [StringLength(30)]
        public string? CfsRemovalChargeCode { get; set; }
        /// <summary>
        /// If it has value, then when click the button &apos;Charges&apos; in ivcr1 which TrxType=5, it will auto calculate the charges.
        /// </summary>
        [StringLength(30)]
        public string? CfsStorageChargeCode { get; set; }
        /// <summary>
        /// If set as Y, then it will display in Sea Import Consol as below base on EDI Count of the master. If EDI count &gt;0 then show Y. Otherwise show N
        /// </summary>
        [StringLength(1)]
        public string? CfsUploadFlag { get; set; }
        /// <summary>
        /// If set as N, it will not prompt the message and it will not change the Job No of the House
        /// </summary>
        [StringLength(1)]
        public string? ChangeMasterJobNoFlag { get; set; }
        [StringLength(30)]
        public string? ChargeCollectItemCode { get; set; }
        /// <summary>
        /// Default the Destination Code when entering a new B/L
        /// </summary>
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        /// <summary>
        /// Define which line the Commodity Description will default  to Goods Description under the Cargo Info tab
        /// </summary>
        public int? CommodityDescriptionRow { get; set; }
        /// <summary>
        /// Default to the Haulier in Consol screen(for GP)
        /// </summary>
        [StringLength(10)]
        public string? ConsolTransportCompanyCode { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then if the CargoType is FCL, the Container No in sibl2 can leave blank
        /// </summary>
        [StringLength(1)]
        public string? ContainerNoBlankFlag { get; set; }
        /// <summary>
        /// Define which Job Type &apos;s job can be copied on LCL Consol.
        /// </summary>
        [StringLength(10)]
        public string? CopyConsolJobType { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, and all the container in master job Multiple Container is not ticked, then it will pull all container from master to house when create new houe
        /// </summary>
        [StringLength(1)]
        public string? CopyContainerFlag { get; set; }
        [StringLength(1)]
        public string? CopyMasterHouseFlag { get; set; }
        /// <summary>
        /// Define the which PartyType when F4 or auto search the Customer Code in sebk1. e.g If set as &apos;&apos;CL,OA&apos;,  then F4 search and auto search Customer Code in sebk1, should filter Rcbp1.PartyType is CL, OA, blank or null
        /// </summary>
        [StringLength(50)]
        public string? CustomerPartyType { get; set; }
        /// <summary>
        /// Default the Cargo Type in Import BL if the control of the cargo type is not set in INI.
        /// </summary>
        [StringLength(1)]
        public string? DefaultCargoTypeFlag { get; set; }
        /// <summary>
        /// if set as C then it will default the CustomerCode, Customer Name to Consignee Code and Consignee Name when add new sibl1. The address of the Consignee will also default from rcbp1 base on the Consignee Code.
        /// </summary>
        [StringLength(1)]
        public string? DefaultConsignee { get; set; }
        /// <summary>
        /// Default the Customer Code when entering a new B/L
        /// </summary>
        [StringLength(10)]
        public string? DefaultCustomerCode { get; set; }
        /// <summary>
        /// Default the Document List to display the Trx Type of Document e.g. IV for Invoice, CN for Credit Note, DN for Debite Note, CI for Cash Invoice, CR for Cash Receipt, 0 for Ivcr1_0, 1 for Ivcr1_1, 2 for Ivcr1_2, 3 for Ivcr1_3, 4 for Ivcr1_4, 5 for Ivcr1_5, 6 for Ivcr1_6, 7 for Ivcr1_7,  8 for Ivcr1_8, 9 for Ivcr1_9
        /// </summary>
        [StringLength(2)]
        public string? DefaultDocument { get; set; }
        /// <summary>
        /// Default the TransportCompanyCode, Name and address from rcbp1 to sibl1 when adding a new record (don&apos;t auto default but add a button &quot;Default Transport Company&quot;
        /// </summary>
        [StringLength(10)]
        public string? DefaultTransportCompanyCode { get; set; }
        /// <summary>
        /// Default the Vendor Name of the Payment Voucher as Coloader or Shipping Line
        /// </summary>
        [StringLength(1)]
        public string? DefaultVendorNameFlag { get; set; }
        [StringLength(1)]
        public string? DirectHouseFlag { get; set; }
        /// <summary>
        /// Print to Footer 1 of the Sea Import related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        /// <summary>
        /// Print to Footer 2 of the Sea Import related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("DraftOBLNoFlag")]
        [StringLength(1)]
        public string? DraftOblnoFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("DraftOBLNoPrefix")]
        [StringLength(11)]
        public string? DraftOblnoPrefix { get; set; }
        /// <summary>
        /// When it is a transhipment job and the export job is confirmed and the sipa1.LockFreightCollectFlag =&apos;Y&apos;, allow user to edit, but it will update to sebl3
        /// - A mean only access right is A will show.
        /// - S mean access right is A or S will show.
        /// - U mean all user will show.
        /// </summary>
        [StringLength(1)]
        public string? EditFrtCollectFlag { get; set; }
        /// <summary>
        /// Default to the Haulier in Consol screen(for FC)
        /// </summary>
        [StringLength(10)]
        public string? FclTransportCompanyCode { get; set; }
        /// <summary>
        /// Define no. of Free Storage day for the cargo when compute the billing
        /// </summary>
        public int? FreeStorageDay { get; set; }
        /// <summary>
        /// Define the Item Code for the Freight Collect Charge. It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? FreightCollectItemCode { get; set; }
        /// <summary>
        /// Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? FreightItemCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(30)]
        public string? GateChargeCode { get; set; }
        /// <summary>
        /// If there is the value, the system should show print button under Haulier screen(click &apos;...&apos; button)
        /// </summary>
        [StringLength(50)]
        public string? HaulierReport1 { get; set; }
        /// <summary>
        /// If there is the value, the system should show print button under Haulier screen(click &apos;...&apos; button)
        /// </summary>
        [StringLength(50)]
        public string? HaulierReport2 { get; set; }
        /// <summary>
        /// Define the button name
        /// </summary>
        [StringLength(50)]
        public string? HaulierReportLabel1 { get; set; }
        /// <summary>
        /// Define the button name
        /// </summary>
        [StringLength(50)]
        public string? HaulierReportLabel2 { get; set; }
        /// <summary>
        /// J to default the HB/L same as Job No.
        /// </summary>
        [Column("HBlNoFlag")]
        [StringLength(1)]
        public string? HblNoFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("HBlPrefix")]
        [StringLength(11)]
        public string? HblPrefix { get; set; }
        [StringLength(1)]
        public string? HideExportBlSurrenderedFlag { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos;, then it will hide Export Info and T/S Info buttons
        /// </summary>
        [StringLength(1)]
        public string? HideTsButtonFlag { get; set; }
        /// <summary>
        /// Set as Y to update the House Seq No in Jmjm1 when any house job is create in sea export
        /// </summary>
        [StringLength(1)]
        public string? HouseSeqNoFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? InvoiceTrfBy { get; set; }
        /// <summary>
        /// Job Date is defined as ETA/ETD - ETA Date or JCD - Job Creation Date
        /// </summary>
        [StringLength(3)]
        public string? JobDateType { get; set; }
        /// <summary>
        /// Set as 0: Direct/Master= 00; House= 01-99. Set as 1: Direct= Z; Master= 0; House= A-Y
        /// </summary>
        [StringLength(1)]
        public string? JobFormatType { get; set; }
        /// <summary>
        /// Job running no. is created by C - Continously, M - Monthly, S - Shipment Type
        /// </summary>
        [StringLength(1)]
        public string? JobNoFlag { get; set; }
        /// <summary>
        /// [FXX:Std Prefix],[SFX:Suffix],[S:Shipment Type],[ORG:Origin Code],[DST:Dest Code],[MM:01-12],[M:1-9/A-C],[YY:01-99],[Y:0-9]
        /// </summary>
        [StringLength(255)]
        public string? JobNoFormat { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? JobPostBy { get; set; }
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
        public DateTime? LastInvoiceTrfDate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastJobPostDate { get; set; }
        [StringLength(1)]
        public string? LockCloseJobPermitFlag { get; set; }
        /// <summary>
        /// If set as &apos;N&apos;, then it will not lock the Freight Collect. If set as &apos;Y&apos;, for sibl1 transhipment job if already generate export job no(sebl1), the sibl1.FreightCollect will show sebl3 record
        /// </summary>
        [StringLength(1)]
        public string? LockFreightCollectFlag { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos;, then it will lock the Transhipment Rate and Imort Rate in sebl1 and sibl1 for Transhipment Job if the Job is closed either in sebl1 or sibl1
        /// </summary>
        [StringLength(1)]
        public string? LockTranshipmentRateFlag { get; set; }
        /// <summary>
        /// set to Y it will lock the sibl2(Cargo Info tab) if the export booking ‘s Master Job in sebl1 CloseConsolFlag =Y
        /// </summary>
        [StringLength(1)]
        public string? LockTsJobExportCloseFlag { get; set; }
        /// <summary>
        /// Next Consol Job No
        /// </summary>
        [StringLength(7)]
        public string? NextConsolJobNo { get; set; }
        /// <summary>
        /// Next Direct Job No
        /// </summary>
        [StringLength(7)]
        public string? NextDirectJobNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("NextDraftOBLNo")]
        [StringLength(7)]
        public string? NextDraftOblno { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("NextHBlNo")]
        [StringLength(7)]
        public string? NextHblNo { get; set; }
        /// <summary>
        /// Next Job No when Job No Flag is set as C
        /// </summary>
        [StringLength(7)]
        public string? NextJobNo { get; set; }
        /// <summary>
        /// Next Job No for Mth 01 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth01 { get; set; }
        /// <summary>
        /// Next Job No for Mth 02 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth02 { get; set; }
        /// <summary>
        /// Next Job No for Mth 03 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth03 { get; set; }
        /// <summary>
        /// Next Job No for Mth 04 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth04 { get; set; }
        /// <summary>
        /// Next Job No for Mth 05 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth05 { get; set; }
        /// <summary>
        /// Next Job No for Mth 06 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth06 { get; set; }
        /// <summary>
        /// Next Job No for Mth 07 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth07 { get; set; }
        /// <summary>
        /// Next Job No for Mth 08 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth08 { get; set; }
        /// <summary>
        /// Next Job No for Mth 09 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth09 { get; set; }
        /// <summary>
        /// Next Job No for Mth 10 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth10 { get; set; }
        /// <summary>
        /// Next Job No for Mth 11 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth11 { get; set; }
        /// <summary>
        /// Next Job No for Mth 12 when Job No Flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth12 { get; set; }
        [StringLength(10)]
        public string? NominationSalesmanCode { get; set; }
        [StringLength(30)]
        public string? OrderItemCode { get; set; }
        /// <summary>
        /// It will replace the label name of the Permit/Approve No in B/L shipment info
        /// </summary>
        [StringLength(50)]
        public string? PermitName { get; set; }
        /// <summary>
        /// If set as &apos;N&apos;, then it will hide the button &apos;T/S Info&apos; and don&apos;t prompt the T/S Info screen. If set as &apos;Y&apos; or blank, then existing logic
        /// </summary>
        [StringLength(1)]
        public string? PromptTranshipmentInfoFlag { get; set; }
        /// <summary>
        /// Define the Rebate Item Code when click the Rebate button under the Billing Info and click the button Transhipment button under the Document List
        /// </summary>
        [StringLength(30)]
        public string? RebateItemCode { get; set; }
        public int? SetAddressLength { get; set; }
        /// <summary>
        /// Set the Description length in Cargo info
        /// </summary>
        public int? SetDescriptionLength { get; set; }
        /// <summary>
        /// Set the Description row in Cargo info
        /// </summary>
        public int? SetDescriptionRow { get; set; }
        /// <summary>
        /// Set the Mark length in Cargo info
        /// </summary>
        public int? SetMarksLength { get; set; }
        public int? SetNameLength { get; set; }
        [StringLength(1)]
        public string? ShowChargeWeightFlag { get; set; }
        /// <summary>
        /// e.g if leave blank, then those 4 columns – N,T,R,W will show on the grid. If set as ‘N,T’, then just show N and T column. Same the logic for Import Consol
        /// </summary>
        [StringLength(50)]
        public string? ShowConsolColumn { get; set; }
        [StringLength(1)]
        public string? ShowDeliveryDateFlag { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos;, then the DG Cargo is &apos;Y&apos;, then show the DG Cargo Tab and hide the &apos;...&apos; button and the below 4 text box - Un No, IMCO, FP, PSN. if set as &apos;N&apos; or leave blank, then use old logic (don&apos;t show the DG Cargo tab even if the DG Cargo is &apos;Y&apos;)
        /// </summary>
        [StringLength(1)]
        public string? ShowDgCargoTabFlag { get; set; }
        [StringLength(1)]
        public string? ShowEmptyDateFlag { get; set; }
        /// <summary>
        /// If set as ‘Y’, then when transhipmentFlag=’Y’ and there is Export Info will change to show sebk1 details
        /// </summary>
        [StringLength(1)]
        public string? ShowExportInfoFlag { get; set; }
        [StringLength(1)]
        public string? ShowRequestDateFlag { get; set; }
        [StringLength(5)]
        public string? ShowTotalContainer { get; set; }
        [StringLength(1)]
        public string? ShowTruckingDateFlag { get; set; }
        [StringLength(1)]
        public string? ShowTruckOutDateFlag { get; set; }
        /// <summary>
        /// Define the Storage Charge Code
        /// </summary>
        [StringLength(30)]
        public string? StorageChargeCode { get; set; }
        [StringLength(1)]
        public string? SubHouseCopyFlag { get; set; }
        [StringLength(1)]
        public string? SubHouseJobNoFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then when click the button &apos;Create Booking&apos; on T/S Info in sibl1 or click the button &apos;Consol Booking&apos; in sibl1 to create the booking, the Booking No&apos;s Prefix should be sipa1.TranshipmentBookingPrefix , and next no generate accroding sanm1
        /// </summary>
        [StringLength(1)]
        public string? TranshipmentBookingNoFlag { get; set; }
        /// <summary>
        /// Define the  prefix for Booking No when create the booking from sibl1.
        /// </summary>
        [StringLength(20)]
        public string? TranshipmentBookingPrefix { get; set; }
        [StringLength(30)]
        public string? TranshipmentChargeCode { get; set; }
        /// <summary>
        /// If set as ‘Y’, then when sibl1.TranshipmentFlag=’Y’, hide the ‘Delivery Info’ and ‘Vessel Detail’ tabl in sibl1
        /// </summary>
        [StringLength(1)]
        public string? TranshipmentHideTabFlag { get; set; }
        /// <summary>
        /// Define the Item Code in ivcr2 when create invoice accroding Transhipment button under the Document List
        /// </summary>
        [StringLength(30)]
        public string? TranshipmentItemCode { get; set; }
        /// <summary>
        /// Define the Remark of Item Description in ivcr2 when create invoice accroding Transhipment button under the Document List
        /// </summary>
        [StringLength(50)]
        public string? TranshipmentItemDescription { get; set; }
        /// <summary>
        /// If set as N, when TranshipmentFlag is Y in sibl1, the Qty, UnitRate, CurrCode, CurrRate, LocalAmt, Amt  in Freight Collect screen do not update to Billing Info screen and Jost Costing.
        /// </summary>
        [StringLength(1)]
        public string? TsFrtCollectFlag { get; set; }
        [StringLength(1)]
        public string? UpperCaseFlag { get; set; }
        /// <summary>
        /// If set as &apos;N&apos;, then it will not call up sebk1 but it will auto create the booking in export and prompt user “The new export booking xxxxxx is created. “
        /// </summary>
        [StringLength(1)]
        public string? ViewExportConsolBookingFlag { get; set; }
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
        [StringLength(1)]
        public string? ShowSourceJobDocFlag { get; set; }
    }
}
