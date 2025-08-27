using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sepa1")]
    public partial class Sepa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// When call up the Booking No. it will auto add zero in front of the number
        /// </summary>
        [StringLength(1)]
        public string? AppendBookingNoFlag { get; set; }
        /// <summary>
        /// Define the ATA label in Vessel Schedule and sebk1 the system will update BLAttachmentFlag=Y.
        /// </summary>
        [StringLength(10)]
        public string? AtaName { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos; and there are more than one record in sebl2,
        /// </summary>
        [StringLength(1)]
        public string? AutoAttachFlag { get; set; }
        /// <summary>
        /// If set as &apos;N&apos;, then when change the ETD of the Master, it should not auto the BL Issue Date and Landen Date of house bl
        /// </summary>
        [StringLength(1)]
        public string? AutoUpdateBlDateFlag { get; set; }
        [StringLength(1)]
        public string? AutoUpdateDestFlag { get; set; }
        [StringLength(1)]
        public string? AutoUpdateUcrNoFlag { get; set; }
        /// <summary>
        /// Default the Bank Acc Code to the payment Voucher
        /// </summary>
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        /// <summary>
        /// Define the BankCode to default the BankCode in ivcr1_5
        /// </summary>
        [StringLength(10)]
        public string? BankCode { get; set; }
        [StringLength(50)]
        public string? BlChargeCopyJobCosting { get; set; }
        /// <summary>
        /// Default the Currency Code when entering a new B/L
        /// </summary>
        [StringLength(3)]
        public string? BlCurrCode { get; set; }
        /// <summary>
        /// e.g. 4 then when change the Dest Code in sebl1, it will check BlDestCode and if left(BlNo,4,3)=DestCode. It will auto replace the BlNo. with new Dest Code
        /// </summary>
        [StringLength(2)]
        public string? BlDestCodePosition { get; set; }
        /// <summary>
        /// Default the Place of Issue when entering a new B/L
        /// </summary>
        [StringLength(45)]
        public string? BlIssuePlace { get; set; }
        [StringLength(1)]
        public string? BlockCreateBookingFlag { get; set; }
        /// <summary>
        /// Default the B/L Surrender when entering a new B/L
        /// </summary>
        [StringLength(1)]
        public string? BlSurrenderFlag { get; set; }
        [StringLength(255)]
        public string? BookingConfirmEmailAddress { get; set; }
        [StringLength(50)]
        public string? BookingConfirmReportName { get; set; }
        /// <summary>
        /// control Sea booking button confrim generate JobNo or not
        /// </summary>
        [StringLength(1)]
        public string? BookingCreateJobNoFlag { get; set; }
        /// <summary>
        /// e.g. 4 then when change the Dest Code in sebk1, it will check BookingDestCode and if left(BookingNo,4,3)=DestCode. It will auto replace the BookingNo. with new Dest Code
        /// </summary>
        [StringLength(2)]
        public string? BookingDestCodePosition { get; set; }
        [StringLength(1)]
        public string? BookingNoFlag { get; set; }
        /// <summary>
        /// Define the Booking Term and Condition
        /// </summary>
        [StringLength(3000)]
        public string? BookingTermAndCondition { get; set; }
        /// <summary>
        /// Define the report name
        /// </summary>
        [StringLength(50)]
        public string? CargoLoadReport1 { get; set; }
        /// <summary>
        /// Define the report name
        /// </summary>
        [StringLength(50)]
        public string? CargoLoadReport2 { get; set; }
        /// <summary>
        /// Define the 1st button name on the Cargo Load Plan
        /// </summary>
        [StringLength(50)]
        public string? CargoLoadReportLabel1 { get; set; }
        /// <summary>
        /// Define the 2nd button name on the Cargo Load Plan
        /// </summary>
        [StringLength(50)]
        public string? CargoLoadReportLabel2 { get; set; }
        /// <summary>
        /// Default the Cash Acc Code to the Cash Receipt
        /// </summary>
        [StringLength(15)]
        public string? CashAccCode { get; set; }
        /// <summary>
        /// if set as &apos;A&apos;, then only access right=A can change Booking No. if set as &apos;S&apos;, then access right=A or S can change Booking No. if set as &apos;U&apos; or blank, then all users can change Booking No
        /// </summary>
        [StringLength(1)]
        public string? ChangeBookingNoFlag { get; set; }
        /// <summary>
        /// If set as N, it will not prompt the message and it will not change the Job No of the House
        /// </summary>
        [StringLength(1)]
        public string? ChangeMasterJobNoFlag { get; set; }
        [StringLength(1)]
        public string? ChangeMasterUpdateFlag { get; set; }
        /// <summary>
        /// Sebl1.VoyageID &lt;&gt; &apos; &apos;,the below fields (refer to below) in Consol booking screen and sebl1 if shipment is &apos;M&apos;  should be locked base on the access right, should not allow right key and left right:
        /// ETD / ETA 
        /// Vessel Code / Vessel Name 
        /// Voyage No 
        /// PortOfDischargeCode / PortOfDischargeName
        /// 
        /// - Blank, use the old logic.(locked  access right  U, refer to 
        /// - U, all AccessRights are not locked
        /// - S, locked  AccessRight  U
        /// - A, locked  AccessRight  U,S
        /// </summary>
        [StringLength(1)]
        public string? ChangeSchedule { get; set; }
        /// <summary>
        /// Default the Origin code when entering a new B/L
        /// </summary>
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        /// <summary>
        /// If set as &apos;U&apos;, mean U or above can close consol. S - S or above.
        /// </summary>
        [StringLength(1)]
        public string? CloseConsolRight { get; set; }
        /// <summary>
        /// Define the number of day the Vessel Schedule should be closed
        /// </summary>
        public short? CloseScheduleDay { get; set; }
        /// <summary>
        /// If set as ‘N’ or leave blank, then current logic,if the sebl1.CloseConsol=’Y’, if set as ‘Y’ or ‘U’, then all user can edit the booking, if set as ‘S’, then only access right =’S’ or ‘A’ can edit the booing, if set as ‘A’, then only access right =’A’ can edit the booking. Except &apos;Go Master&apos;/&apos;Extra Info&apos;/&apos;Billing Info&apos;button.
        /// - Billing Info allow user to add new or edit
        /// - Extra Info read only
        /// </summary>
        [StringLength(1)]
        public string? ClsConsolBookingAccessRight { get; set; }
        /// <summary>
        /// Define which line the Commodity Description will default  to Goods Description under the Cargo Info tab
        /// </summary>
        public int? CommodityDescriptionRow { get; set; }
        /// <summary>
        /// The Business Party code of the Company. Default as Shipper Code in the OB/L
        /// </summary>
        [StringLength(10)]
        public string? CompanyCode { get; set; }
        /// <summary>
        /// Default the Name of the Company as Shipper Name in the OB/L
        /// </summary>
        [StringLength(80)]
        public string? CompanyName { get; set; }
        /// <summary>
        /// Default the Address 1 of the Company as Shipper Address 1 in the OB/L
        /// </summary>
        [StringLength(60)]
        public string? CompanyAddress1 { get; set; }
        /// <summary>
        /// Default the Address 2 of the Company as Shipper Address 2 in the OB/L
        /// </summary>
        [StringLength(60)]
        public string? CompanyAddress2 { get; set; }
        /// <summary>
        /// Default the Address 3 of the Company as Shipper Address 3 in the OB/L
        /// </summary>
        [StringLength(60)]
        public string? CompanyAddress3 { get; set; }
        /// <summary>
        /// Default the Address 4 of the Company as Shipper Address 4 in the OB/L
        /// </summary>
        [StringLength(60)]
        public string? CompanyAddress4 { get; set; }
        [StringLength(100)]
        public string? ConfirmBookingRemark { get; set; }
        /// <summary>
        /// Set as Y when add a new consol booking need confirmation to generate Master Job No.
        /// </summary>
        [StringLength(1)]
        public string? ConfirmConsolBookingFlag { get; set; }
        /// <summary>
        /// Set as N the consol Info screen will not allow user to click Select All and Consol button
        /// </summary>
        [StringLength(1)]
        public string? ConsolBlFlag { get; set; }
        /// <summary>
        /// Define the Job Type when click the button &apos;Consol Booking&apos; to list the Export Job will filter
        /// </summary>
        [StringLength(200)]
        public string? ConsolBookingJobType { get; set; }
        [StringLength(1)]
        public string? ConsolDestEtaFlag { get; set; }
        [StringLength(1)]
        public string? ConsolJobFlag { get; set; }
        /// <summary>
        /// If set as &apos;N&apos;, it will disable the &apos;New Sub Master&apos; button on Consol screen.
        /// </summary>
        [StringLength(1)]
        public string? ConsolSubMasterFlag { get; set; }
        /// <summary>
        /// For Sea Booking Container Search Button, set as &quot;ApiServer,Database,LoginId,Password&quot;
        /// </summary>
        [Column("ContainerMainDatabaseURL")]
        [StringLength(200)]
        public string? ContainerMainDatabaseUrl { get; set; }
        /// <summary>
        /// default the Container Type 1 to sebk1
        /// </summary>
        [StringLength(5)]
        public string? ContainerType1 { get; set; }
        /// <summary>
        /// default the Container Type 2 to sebk1
        /// </summary>
        [StringLength(5)]
        public string? ContainerType2 { get; set; }
        /// <summary>
        /// default the Container Type 3 to sebk1
        /// </summary>
        [StringLength(5)]
        public string? ContainerType3 { get; set; }
        /// <summary>
        /// default the Container Type 4 to sebk1
        /// </summary>
        [StringLength(5)]
        public string? ContainerType4 { get; set; }
        /// <summary>
        /// if set as B mean copy booking sebk1 just copy sebk1 not sebl1
        /// </summary>
        [StringLength(1)]
        public string? CopyBookingFlag { get; set; }
        /// <summary>
        /// Define which Job Type &apos;s job can be copied on LCL Consol.
        /// </summary>
        [StringLength(10)]
        public string? CopyConsolJobType { get; set; }
        /// <summary>
        /// When click Copy Container, it will copy the Container and Seal No. and it will copy the CopyContainerDescription also to ghe first row of the Mark
        /// </summary>
        [StringLength(25)]
        public string? CopyContainerDescription { get; set; }
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
        /// If set as Y, default the Cargo Type = &apos;LCL&apos;  in Direct Booking if the control of the Cargo Type is not set in INI.
        /// </summary>
        [StringLength(1)]
        public string? DefaultCargoTypeFlag { get; set; }
        /// <summary>
        /// default the Close Date by ETD Date in sebk1 and Consol Booking.
        /// e.g  ‘1’ mean ETD -1 but exclude Sunday and Saturday. Both Add and Edit mode will change.
        /// </summary>
        public int? DefaultCloseDate { get; set; }
        /// <summary>
        /// If set as ‘ATA’, to default the Close Date by ATA Date in sebk1 and Consol Booking base on the sepa1.DefaultCloseDate. e.g. DefaultCloseDate set as ‘1’, mean ATA-1 but exclude Sunday and Saturday. Both Add and Edit mode will change.
        /// If set as ‘ETD’ or blank, then default the Close Date by ETD Date.
        /// </summary>
        [StringLength(10)]
        public string? DefaultCloseDateType { get; set; }
        /// <summary>
        /// if DefaultCloseTime has value. e.g. 12:00, then when default the Close Date by ATA or ETD, it will also default the Close Time as 12:00 in sebk1 and Consol Booking
        /// </summary>
        [StringLength(5)]
        public string? DefaultCloseTime { get; set; }
        /// <summary>
        /// Default the Document List to display the Trx Type of Document e.g. IV for Invoice, CN for Credit Note, DN for Debite Note, CI for Cash Invoice, CR for Cash Receipt, 0 for Ivcr1_0, 1 for Ivcr1_1, 2 for Ivcr1_2, 3 for Ivcr1_3, 4 for Ivcr1_4, 5 for Ivcr1_5, 6 for Ivcr1_6, 7 for Ivcr1_7,  8 for Ivcr1_8, 9 for Ivcr1_9
        /// </summary>
        [StringLength(2)]
        public string? DefaultDocument { get; set; }
        [StringLength(1)]
        public string? DefaultEtaFlag { get; set; }
        /// <summary>
        /// If &apos;Select Distinct UomCode from sebl2&apos; have more than one records, then update the sepa1.DefaultPackage to sebl1.UomCode, the UomDescription pull from rcum1 base on the UomCode. If &apos;Select Distinct UomCode from sebl2&apos; only has one record, then update the sebl2.UomCode to sebl1.UomCode. when change the sebl2.UomCode, it should always update to sebl1.UomCode, no matter sebl1.UomCode has value or not
        /// </summary>
        [StringLength(3)]
        public string? DefaultPackage { get; set; }
        /// <summary>
        /// Default the TransportCompanyCode, Name and address from rcbp1 to sebk1and semp1 when adding a new record (sebk1 don&apos;t auto default but add a button &quot;Default Transport Company&quot;
        /// </summary>
        [StringLength(10)]
        public string? DefaultTransportCompanyCode { get; set; }
        /// <summary>
        /// Default the Vendor Name of the Payment Voucher as Coloader or Shipping Line
        /// </summary>
        [StringLength(1)]
        public string? DefaultVendorNameFlag { get; set; }
        /// <summary>
        /// Set as Y then when confirm the House Booking it will auto save as Direct Job when no Master Job is attached.
        /// </summary>
        [StringLength(1)]
        public string? DirectHouseFlag { get; set; }
        /// <summary>
        /// Print to Footer 1 of the Sea Export related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        /// <summary>
        /// Print to Footer 2 of the Sea Export related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        /// <summary>
        /// Set as J the OB/L No. will be the same as Job No. Set as D the OB/L No. will be created from the Draft OB/L No Prefix and Next Draft OB/L No.
        /// </summary>
        [Column("DraftOBLNoFlag")]
        [StringLength(1)]
        public string? DraftOblnoFlag { get; set; }
        /// <summary>
        /// Define the OB/L Prefix Format:YY,MM,DST or FXX
        /// </summary>
        [Column("DraftOBLNoPrefix")]
        [StringLength(11)]
        public string? DraftOblnoPrefix { get; set; }
        /// <summary>
        /// Default the ETA after No. of day in define Eta Day when Etd Flag set as Y
        /// </summary>
        public short? EtaDay { get; set; }
        /// <summary>
        /// Default the ETD as today date in Direct Booking entry when set as Y
        /// </summary>
        [StringLength(1)]
        public string? EtdFlag { get; set; }
        /// <summary>
        /// Default the Description to the 1st Description in Cargo Info for FCL shipment
        /// </summary>
        [StringLength(50)]
        public string? FclCargoDescription { get; set; }
        /// <summary>
        /// Define the font type for the Sebl1.Description XX and CommodityDescriptionXX
        /// </summary>
        [StringLength(50)]
        public string? FontType { get; set; }
        [StringLength(255)]
        public string? FreeDayEmail { get; set; }
        [StringLength(50)]
        public string? FreeDaysReportName { get; set; }
        /// <summary>
        /// Define no. of Free Storage day for the cargo when compute the billing
        /// </summary>
        public int? FreeStorageDay { get; set; }
        /// <summary>
        /// Define the Item code for the Freight Charge. It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? FreightItemCode { get; set; }
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
        /// J to default the HB/L same as Job No. H to create the HB/L No. base on the HBL Prefix and Next HBL No.
        /// </summary>
        [Column("HBlNoFlag")]
        [StringLength(1)]
        public string? HblNoFlag { get; set; }
        /// <summary>
        /// HB/L Prefix combination of FXX,DST,ORG,S,YY,Y,MM,M,DD
        /// </summary>
        [Column("HBlPrefix")]
        [StringLength(11)]
        public string? HblPrefix { get; set; }
        /// <summary>
        /// FXX,NN
        /// </summary>
        [Column("HBlSuffix")]
        [StringLength(20)]
        public string? HblSuffix { get; set; }
        /// <summary>
        /// then hide the BL column on the Charge Info tab in sebl1
        /// </summary>
        [StringLength(1)]
        public string? HideBlColumnFlag { get; set; }
        [StringLength(1)]
        public string? HideBookingCheckBoxFlag { get; set; }
        [StringLength(1)]
        public string? HideChangeBkgNoFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos; then when confirm booking should not prompt screen. Also if the booking is unconfirmed, when click the button &apos;B/L Preparation&apos;, it should prompt message &quot;Do you want to confirm this House Booking?&quot;
        /// </summary>
        [StringLength(1)]
        public string? HideConfirmMessageFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then hide the Country Of Origin in sebk1
        /// </summary>
        [StringLength(1)]
        public string? HideCountryOfOriginFlag { get; set; }
        [StringLength(1)]
        public string? HideImportJobFlag { get; set; }
        [Column("HideOriginalBLFlag")]
        [StringLength(1)]
        public string? HideOriginalBlflag { get; set; }
        [StringLength(1)]
        public string? HideUpdateBlFlag { get; set; }
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
        /// Job Date is defined as ETD - ETD Date or JCD - Job Creation Date
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
        [StringLength(1)]
        public string? KeepCombineBookingFlag { get; set; }
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
        [StringLength(1)]
        public string? LockConfirmBookingFlag { get; set; }
        [StringLength(1)]
        public string? LockFreightCollectFlag { get; set; }
        /// <summary>
        /// For Sub House Job Suffix. Set as Y will be XX, N will be N
        /// </summary>
        [StringLength(1)]
        public string? LongSubHouseSuffixFlag { get; set; }
        [StringLength(1)]
        public string? ManualBookingNoFlag { get; set; }
        /// <summary>
        /// Set as Y to manaully create the Voyage ID
        /// </summary>
        [StringLength(1)]
        public string? ManualVoyageIdFlag { get; set; }
        [StringLength(1)]
        public string? MinChargeWeightFlag { get; set; }
        /// <summary>
        /// Next Consol Job No
        /// </summary>
        [StringLength(7)]
        public string? NextConsolJobNo { get; set; }
        /// <summary>
        /// Nex Direct Job No
        /// </summary>
        [StringLength(7)]
        public string? NextDirectJobNo { get; set; }
        /// <summary>
        /// Nex OB/L No
        /// </summary>
        [Column("NextDraftOBLNo")]
        [StringLength(7)]
        public string? NextDraftOblno { get; set; }
        /// <summary>
        /// Next HB/L No
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
        /// Next Job No for Mth 01 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth01 { get; set; }
        /// <summary>
        /// Next Job No for Mth 02 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth02 { get; set; }
        /// <summary>
        /// Next Job No for Mth 03 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth03 { get; set; }
        /// <summary>
        /// Next Job No for Mth 04 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth04 { get; set; }
        /// <summary>
        /// Next Job No for Mth 05 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth05 { get; set; }
        /// <summary>
        /// Next Job No for Mth 06 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth06 { get; set; }
        /// <summary>
        /// Next Job No for Mth 07 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth07 { get; set; }
        /// <summary>
        /// Next Job No for Mth 08 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth08 { get; set; }
        /// <summary>
        /// Next Job No for Mth 09 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth09 { get; set; }
        /// <summary>
        /// Next Job No for Mth 10 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth10 { get; set; }
        /// <summary>
        /// Next Job No for Mth 11 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth11 { get; set; }
        /// <summary>
        /// Next Job No for Mth 12 when Job No flag is set as M
        /// </summary>
        [StringLength(7)]
        public string? NextJobNoMth12 { get; set; }
        /// <summary>
        /// If sebk1.NominationFlag=Y, define the Charge Item Code when click the button &apos;Rate Compute&apos; to insert the record to sebl3.
        /// </summary>
        [StringLength(30)]
        public string? NominationItemCode { get; set; }
        [StringLength(10)]
        public string? NominationSalesmanCode { get; set; }
        [StringLength(250)]
        public string? OnlineBookingEmail { get; set; }
        /// <summary>
        /// It will replace the label name of the Permit/Approve No in B/L shipment info
        /// </summary>
        [StringLength(50)]
        public string? PermitName { get; set; }
        /// <summary>
        /// Define the Item Code to ivcr2 when click the button &apos;Generate Invoice under the Profit Share tab on Consol Booking.
        /// </summary>
        [StringLength(30)]
        public string? ProfitShareItemCode { get; set; }
        [StringLength(1)]
        public string? PromptMasterInfoFlag { get; set; }
        /// <summary>
        /// Default the Item Code to the Billing Info in B/L when click the Rebate button. It must be valid Item Code in Charge List
        /// </summary>
        [StringLength(30)]
        public string? RebateItemCode { get; set; }
        [StringLength(200)]
        public string? ReleaseOrderJobType { get; set; }
        [StringLength(50)]
        public string? ReleaseOrderNoField { get; set; }
        /// <summary>
        /// Define the words when click the button &apos;Said To Contain&apos;
        /// </summary>
        [StringLength(50)]
        public string? SaidToContain { get; set; }
        public int? SetDescription01Length { get; set; }
        public int? SetDescription02Length { get; set; }
        /// <summary>
        /// Set the Description length in Cargo info
        /// </summary>
        public int? SetDescriptionLength { get; set; }
        /// <summary>
        /// Define the system show the GoodsDescription on the Cargo Info screen. e.g - if set as &apos;17&apos;, then the sebl2.GoodsDescription18-20 will be hide. If leave blank, then use current logic, show sebl2.MarkNo1-15
        /// </summary>
        public int? SetDescriptionRow { get; set; }
        /// <summary>
        /// Set the Mark length in Cargo info
        /// </summary>
        public int? SetMarksLength { get; set; }
        /// <summary>
        /// Define the system show the MarkNo on the Cargo Info screen. e.g - if set as &apos;17&apos;, then the sebl2.MarkNo18-20 will be hide. If leave blank, then use current logic, show sebl2.GoodsDescription1-15
        /// </summary>
        public int? SetMarkRow { get; set; }
        /// <summary>
        /// Set as Y to show the House Booking No. on the Consol Booking screen .  Set as N to show the Booking Sequence No. 001,002,..
        /// </summary>
        [StringLength(1)]
        public string? ShowActualBookingNo { get; set; }
        [StringLength(1)]
        public string? ShowApproveFreeDays { get; set; }
        [StringLength(1)]
        public string? ShowBlCountryCodeFlag { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos;, the consol screen will show Bl No from sebl1 instead of show Job No.
        /// </summary>
        [StringLength(1)]
        public string? ShowBlFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, it will use the Multiple Container to compute the NoOf20ftContainer, NoOf40ftContainer and NoOf45ftContainer.
        /// </summary>
        [StringLength(1)]
        public string? ShowBookingContainerFlag { get; set; }
        /// <summary>
        /// e.g. If set as &apos;GP,FC&apos;, then the system should only always pull data from Sebk1 on Sebl1(Consol) which job type is &apos;GP&apos; and &apos;FC&apos; regardless booking confirm or not
        /// </summary>
        [StringLength(10)]
        public string? ShowBookingInConsolFlag { get; set; }
        [StringLength(1)]
        public string? ShowChargeWeightFlag { get; set; }
        /// <summary>
        /// Y, mean sea export consol button &quot;consol&quot; screen only show Status CNF
        /// </summary>
        [StringLength(1)]
        public string? ShowConfirmBookingFlag { get; set; }
        /// <summary>
        /// e.g if leave blank, then those 4 columns – N,T,R,W will show on the grid. If set as ‘N,T’, then just show N and T column. Same the logic for Import Consol
        /// </summary>
        [StringLength(50)]
        public string? ShowConsolColumn { get; set; }
        /// <summary>
        /// if set Y, it will display the UN, IMCO,FP to the Commodity on the consol booking screen. Otherwise it will always show the Commodity Description
        /// </summary>
        [StringLength(1)]
        public string? ShowDgCargoConsolFlag { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos;, then the DG Cargo is &apos;Y&apos;, then show the DG Cargo Tab and hide the &apos;...&apos; button and the below 4 text box - Un No, IMCO, FP, PSN. if set as &apos;N&apos; or leave blank, then use old logic (don&apos;t show the DG Cargo tab even if the DG Cargo is &apos;Y&apos;)
        /// </summary>
        [StringLength(1)]
        public string? ShowDgCargoTabFlag { get; set; }
        [StringLength(1)]
        public string? ShowEmptyDateFlag { get; set; }
        [StringLength(1)]
        public string? ShowLadenDateFlag { get; set; }
        [StringLength(1)]
        public string? ShowLooseQtyFlag { get; set; }
        [StringLength(1)]
        public string? ShowMultiplePickupFlag { get; set; }
        /// <summary>
        /// If set as Y, it should show  &apos;Print?&apos; on Sebl1(Consol) screen. Default as &apos;Y&apos;
        /// Create house record under sebl1(Consol) and create sebl1 record at node, the PrintFlag always is blank
        /// </summary>
        [StringLength(1)]
        public string? ShowPrintFlag { get; set; }
        [StringLength(1)]
        public string? ShowTimeForLadenDateFlag { get; set; }
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
        public string? SubHouseCopyPartyFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then it will create the JobNo for sub house job.
        /// </summary>
        [StringLength(1)]
        public string? SubHouseJobNoFlag { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos; then the Transhipment Rate and Import Rate in sebl1 will be unlock and let user to change and it will update to sibl1 Transhipment Rate and Import Rate directly base on ImportJobNo. If there is no ImportJobNo in sebl1, then it will be lock
        /// </summary>
        [StringLength(1)]
        public string? TranshipmentRateFlag { get; set; }
        [StringLength(50)]
        public string? TsBookingCustomerName { get; set; }
        [StringLength(1)]
        public string? UnConfirmBookingFlag { get; set; }
        [StringLength(1)]
        public string? UnlockBlSurrenderFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then when Consol is Closed, the booking remark still can edit
        /// </summary>
        [StringLength(1)]
        public string? UnlockBookingRemarkFlag { get; set; }
        [StringLength(1)]
        public string? UnlockDeliveryInfoFlag { get; set; }
        [StringLength(1)]
        public string? UnlockMasterJobNoFlag { get; set; }
        [StringLength(1)]
        public string? UpdateBookingContainerFlag { get; set; }
        [StringLength(1)]
        public string? UpdateFromSubHouse { get; set; }
        /// <summary>
        /// Just for Master Job. When set as ‘N’, then when add or edit sebl2 should not update sebl1.NoOf20ftContainer, NoOf40ftContainer and NoOf45ftContainer. If set as ‘Y’ or blank, then use old logic
        /// </summary>
        [StringLength(1)]
        public string? UpdateMasterContainerFlag { get; set; }
        /// <summary>
        /// The information in Booking will update to BL entry include Shipper, Consignee, Commodity,Delivery Agent, Salesman Code, Notify Party and Also Notify Party
        /// </summary>
        [StringLength(1)]
        public string? UpdBookingToBlFlag { get; set; }
        /// <summary>
        /// Allow auto change the Mark and Description to upper case
        /// </summary>
        [StringLength(1)]
        public string? UpperCaseFlag { get; set; }
        [StringLength(1)]
        public string? VoyageJobNoFlag { get; set; }
        /// <summary>
        /// Set as Y to pull Vessel Schedule by Voyage No. in the Direct Booking
        /// </summary>
        [StringLength(1)]
        public string? VoyageNoScheduleFlag { get; set; }
        /// <summary>
        /// Default the Warehouse Code to the Staffing Agent in the new Booking, B/L or Consol Booking
        /// </summary>
        [StringLength(10)]
        public string? WarehouseCode { get; set; }
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

        [ForeignKey("BlCurrCode")]
        [InverseProperty("Sepa1s")]
        public virtual Glex1? BlCurrCodeNavigation { get; set; }
    }
}
