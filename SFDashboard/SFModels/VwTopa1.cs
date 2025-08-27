using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTopa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Address 1")]
        [StringLength(50)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(50)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(50)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(50)]
        public string? Address4 { get; set; }
        [Column("App Hide Schedule Time")]
        [StringLength(1)]
        public string? AppHideScheduleTime { get; set; }
        [Column("Auto Generate Job No")]
        [StringLength(1)]
        public string? AutoGenerateJobNo { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Default Tank Container Type")]
        [StringLength(5)]
        public string? DefaultTankContainerType { get; set; }
        [Column("Default TP Job Type")]
        [StringLength(2)]
        public string? DefaultTpJobType { get; set; }
        [Column("Default Trip Type")]
        [StringLength(25)]
        public string? DefaultTripType { get; set; }
        [Column("Default Uom Code")]
        [StringLength(50)]
        public string? DefaultUomCode { get; set; }
        [Column("Delivery Activity Code")]
        [StringLength(25)]
        public string? DeliveryActivityCode { get; set; }
        [Column("Documenation Code")]
        [StringLength(5)]
        public string? DocumenationCode { get; set; }
        [Column("Document Footer 1")]
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        [Column("Document Footer 2")]
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        [Column("Done Flag")]
        [StringLength(6)]
        public string? DoneFlag { get; set; }
        [Column("Driver Incentive Item Code")]
        [StringLength(30)]
        public string? DriverIncentiveItemCode { get; set; }
        [Column("Driver Login Id Flag")]
        [StringLength(1)]
        public string? DriverLoginIdFlag { get; set; }
        [Column("Filter Customer Code Flag")]
        [StringLength(1)]
        public string? FilterCustomerCodeFlag { get; set; }
        [Column("G L Cash Acc Code")]
        [StringLength(15)]
        public string? GLCashAccCode { get; set; }
        [Column("Hide Deployment Job")]
        [StringLength(1)]
        public string? HideDeploymentJob { get; set; }
        [Column("Job Colour Status Alert")]
        [StringLength(20)]
        public string? JobColourStatusAlert { get; set; }
        [Column("Job Colour Status Complete")]
        [StringLength(20)]
        public string? JobColourStatusComplete { get; set; }
        [Column("Job Colour Status Late")]
        [StringLength(20)]
        public string? JobColourStatusLate { get; set; }
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
        [Column("Monthly Job Seq No 01")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo01 { get; set; }
        [Column("Monthly Job Seq No 02")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo02 { get; set; }
        [Column("Monthly Job Seq No 03")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo03 { get; set; }
        [Column("Monthly Job Seq No 04")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo04 { get; set; }
        [Column("Monthly Job Seq No 05")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo05 { get; set; }
        [Column("Monthly Job Seq No 06")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo06 { get; set; }
        [Column("Monthly Job Seq No 07")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo07 { get; set; }
        [Column("Monthly Job Seq No 08")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo08 { get; set; }
        [Column("Monthly Job Seq No 09")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo09 { get; set; }
        [Column("Monthly Job Seq No 10")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo10 { get; set; }
        [Column("Monthly Job Seq No 11")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo11 { get; set; }
        [Column("Monthly Job Seq No 12")]
        [StringLength(4)]
        public string? MonthlyJobSeqNo12 { get; set; }
        [Column("Next Job No")]
        [StringLength(7)]
        public string? NextJobNo { get; set; }
        [Column("Next Transfer Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NextTransferDate { get; set; }
        [Column("Ocean Freight Code")]
        [StringLength(5)]
        public string? OceanFreightCode { get; set; }
        [Column("Odd Size Height", TypeName = "decimal(13, 4)")]
        public decimal? OddSizeHeight { get; set; }
        [Column("Odd Size Length", TypeName = "decimal(13, 4)")]
        public decimal? OddSizeLength { get; set; }
        [Column("Odd Size Width", TypeName = "decimal(13, 4)")]
        public decimal? OddSizeWidth { get; set; }
        [Column("Psa Acc Code")]
        [StringLength(16)]
        public string? PsaAccCode { get; set; }
        [Column("Schedule Fast Print Report Name")]
        [StringLength(100)]
        public string? ScheduleFastPrintReportName { get; set; }
        [Column("Show Extra Info Cntr Flag")]
        [StringLength(1)]
        public string? ShowExtraInfoCntrFlag { get; set; }
        [Column("Stuffing Unstuffing Code")]
        [StringLength(5)]
        public string? StuffingUnstuffingCode { get; set; }
        [Column("Stuffing Unstuffing Mft")]
        [StringLength(5)]
        public string? StuffingUnstuffingMft { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Update Qty Flag")]
        [StringLength(1)]
        public string? UpdateQtyFlag { get; set; }
        [Column("Vehicle Driver Master Flag")]
        [StringLength(1)]
        public string? VehicleDriverMasterFlag { get; set; }
        [Column("Warehouse Storage Code")]
        [StringLength(5)]
        public string? WarehouseStorageCode { get; set; }
        [Column("Weight No Dec Job Type")]
        [StringLength(100)]
        public string? WeightNoDecJobType { get; set; }
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
