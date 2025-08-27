using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("topa1")]
    public partial class Topa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// Default the Address 1 as Transport Address 1 in the Tobk1
        /// </summary>
        [StringLength(50)]
        public string? Address1 { get; set; }
        /// <summary>
        /// Default the Address 2 as Transport Address 2 in the Tobk1
        /// </summary>
        [StringLength(50)]
        public string? Address2 { get; set; }
        /// <summary>
        /// Default the Address 3 as Transport Address 3 in the Tobk1
        /// </summary>
        [StringLength(50)]
        public string? Address3 { get; set; }
        /// <summary>
        /// Default the Address 4 as Transport Address 4 in the Tobk1
        /// </summary>
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(1)]
        public string? AppHideScheduleTime { get; set; }
        [StringLength(1)]
        public string? AutoGenerateJobNo { get; set; }
        /// <summary>
        /// Define the BankCode to default the BankCode in ivcr1_5
        /// </summary>
        [StringLength(10)]
        public string? BankCode { get; set; }
        [StringLength(5)]
        public string? DefaultTankContainerType { get; set; }
        [Column("DefaultTPJobType")]
        [StringLength(2)]
        public string? DefaultTpjobType { get; set; }
        [StringLength(25)]
        public string? DefaultTripType { get; set; }
        [StringLength(50)]
        public string? DefaultUomCode { get; set; }
        [StringLength(25)]
        public string? DeliveryActivityCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? DocumenationCode { get; set; }
        /// <summary>
        /// Print to Footer 1 of the Transport related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        /// <summary>
        /// Print to Footer 2 of the Transport related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        /// <summary>
        /// If topa1.DoneFlag = &quot;DRIVER&quot;, tobk1.Driver Code have enter, the &quot;Done?&quot; should auto change to &quot;Y&quot;.
        /// When save tobk1,  if &quot;Done?&quot; =Y, the system should check if &quot;Driver Code&quot; is blank, if blank, system will prompt and prevent user from saving until user updates the Driver Code&quot;
        /// </summary>
        [StringLength(6)]
        public string? DoneFlag { get; set; }
        [StringLength(30)]
        public string? DriverIncentiveItemCode { get; set; }
        [StringLength(1)]
        public string? DriverLoginIdFlag { get; set; }
        /// <summary>
        /// If set as &apos;N&apos;, enter Customer Code under Tosh1 grid, the system should not filter rcbp1.PartyType
        /// </summary>
        [StringLength(1)]
        public string? FilterCustomerCodeFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("GLCashAccCode")]
        [StringLength(15)]
        public string? GlcashAccCode { get; set; }
        [StringLength(1)]
        public string? HideDeploymentJob { get; set; }
        [StringLength(20)]
        public string? JobColourStatusAlert { get; set; }
        [StringLength(20)]
        public string? JobColourStatusComplete { get; set; }
        [StringLength(20)]
        public string? JobColourStatusLate { get; set; }
        /// <summary>
        /// Job running no. is created by C - Continously, M - Monthly ( only for tobk1_3)
        /// </summary>
        [StringLength(1)]
        public string? JobNoFlag { get; set; }
        /// <summary>
        /// Job Prefix 1 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix1 { get; set; }
        /// <summary>
        /// Job Prefix 2 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix2 { get; set; }
        /// <summary>
        /// Job Prefix 3 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix3 { get; set; }
        /// <summary>
        /// Job Prefix 4 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix4 { get; set; }
        /// <summary>
        /// Job Prefix 5 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix5 { get; set; }
        /// <summary>
        /// Next Job No for Mth 01 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo01 { get; set; }
        /// <summary>
        /// Next Job No for Mth 02 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo02 { get; set; }
        /// <summary>
        /// Next Job No for Mth 03 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo03 { get; set; }
        /// <summary>
        /// Next Job No for Mth 04 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo04 { get; set; }
        /// <summary>
        /// Next Job No for Mth 05 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo05 { get; set; }
        /// <summary>
        /// Next Job No for Mth 06 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo06 { get; set; }
        /// <summary>
        /// Next Job No for Mth 07 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo07 { get; set; }
        /// <summary>
        /// Next Job No for Mth 08 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo08 { get; set; }
        /// <summary>
        /// Next Job No for Mth 09 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo09 { get; set; }
        /// <summary>
        /// Next Job No for Mth 10 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo10 { get; set; }
        /// <summary>
        /// Next Job No for Mth 11 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo11 { get; set; }
        /// <summary>
        /// Next Job No for Mth 12 when Job No flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? MonthlyJobSeqNo12 { get; set; }
        /// <summary>
        /// Next Job No when Job No Flag is set as C
        /// </summary>
        [StringLength(7)]
        public string? NextJobNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? NextTransferDate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? OceanFreightCode { get; set; }
        /// <summary>
        /// Define the limit height of tobk2
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OddSizeHeight { get; set; }
        /// <summary>
        /// Define the limit length of tobk2
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OddSizeLength { get; set; }
        /// <summary>
        /// Define the limit width of tobk2
        /// </summary>
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OddSizeWidth { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(16)]
        public string? PsaAccCode { get; set; }
        /// <summary>
        /// Define the report name for click the print icon in tosh1.
        /// </summary>
        [StringLength(100)]
        public string? ScheduleFastPrintReportName { get; set; }
        [StringLength(1)]
        public string? ShowExtraInfoCntrFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? StuffingUnstuffingCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? StuffingUnstuffingMft { get; set; }
        /// <summary>
        /// The Business Party code of the Company. Default as Transport Company Code in the Tobk1
        /// </summary>
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        /// <summary>
        /// The Business Party code of the Company. Default as Transport Company Code in the Tobk1
        /// </summary>
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [StringLength(1)]
        public string? VehicleDriverMasterFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? WarehouseStorageCode { get; set; }
        [StringLength(100)]
        public string? WeightNoDecJobType { get; set; }
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
        public string? UpdateQtyFlag { get; set; }
    }
}
