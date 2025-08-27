using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtdo1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Auth Number")]
        [StringLength(17)]
        public string? AuthNumber { get; set; }
        [Column("Bill Store Rent Lolo Acc Flag")]
        [StringLength(1)]
        public string? BillStoreRentLoloAccFlag { get; set; }
        [Column("BL No")]
        [StringLength(4000)]
        public string? BlNo { get; set; }
        [Column("Box Care Flag")]
        [StringLength(1)]
        public string? BoxCareFlag { get; set; }
        [Column("Conference,Code")]
        [StringLength(4)]
        public string? ConferenceCode { get; set; }
        [Column("Container No")]
        [StringLength(4000)]
        public string? ContainerNo { get; set; }
        [Column("Container Operator")]
        [StringLength(5)]
        public string? ContainerOperator { get; set; }
        [Column("Depot Code")]
        [StringLength(4)]
        public string? DepotCode { get; set; }
        [Column("EDI Count")]
        public int? EdiCount { get; set; }
        [Column("Err Msg")]
        [StringLength(500)]
        public string? ErrMsg { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Free Period")]
        [StringLength(2)]
        public string? FreePeriod { get; set; }
        [Column("Haulier Name")]
        [StringLength(12)]
        public string? HaulierName { get; set; }
        [Column("Is FCL")]
        public bool? IsFcl { get; set; }
        [Column("Record Type")]
        [StringLength(2)]
        public string? RecordType { get; set; }
        [StringLength(70)]
        public string? Remark { get; set; }
        [Column("Special Conference Container Flag")]
        [StringLength(1)]
        public string? SpecialConferenceContainerFlag { get; set; }
        [Column("Vessel Name")]
        [StringLength(35)]
        public string? VesselName { get; set; }
        [Column("Vouage No")]
        [StringLength(12)]
        public string? VouageNo { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
