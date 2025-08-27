using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("ctdo1")]
    public partial class Ctdo1
    {
        public int TrxNo { get; set; }
        [StringLength(17)]
        public string? AuthNumber { get; set; }
        [StringLength(1)]
        public string? BillStoreRentLoloAccFlag { get; set; }
        [StringLength(4000)]
        public string? BlNo { get; set; }
        [StringLength(1)]
        public string? BoxCareFlag { get; set; }
        [StringLength(4)]
        public string? ConferenceCode { get; set; }
        [StringLength(4000)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerOperator { get; set; }
        [StringLength(4)]
        public string? DepotCode { get; set; }
        public int? EdiCount { get; set; }
        [StringLength(500)]
        public string? ErrMsg { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(2)]
        public string? FreePeriod { get; set; }
        [StringLength(12)]
        public string? HaulierName { get; set; }
        public bool? IsFcl { get; set; }
        [StringLength(2)]
        public string? RecordType { get; set; }
        [StringLength(70)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? SpecialConferenceContainerFlag { get; set; }
        [StringLength(35)]
        public string? VesselName { get; set; }
        [StringLength(12)]
        public string? VoyageNo { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
    }
}
