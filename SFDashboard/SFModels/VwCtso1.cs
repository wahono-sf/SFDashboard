using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtso1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Storing Order No")]
        [StringLength(20)]
        public string StoringOrderNo { get; set; } = null!;
        [Column("Complete Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CompleteDate { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [Column("Consignee Contact Person")]
        [StringLength(50)]
        public string? ConsigneeContactPerson { get; set; }
        [Column("Consignee Contact No")]
        [StringLength(50)]
        public string? ConsigneeContactNo { get; set; }
        [Column("Demurrage Code")]
        [StringLength(10)]
        public string? DemurrageCode { get; set; }
        [Column("Demurrage Free Day")]
        public int? DemurrageFreeDay { get; set; }
        [Column("Demurrage Start Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DemurrageStartDate { get; set; }
        [Column("Depot Code")]
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column("Detention Code")]
        [StringLength(10)]
        public string? DetentionCode { get; set; }
        [Column("Detention Free Day")]
        public int? DetentionFreeDay { get; set; }
        [Column("Detention Start Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DetentionStartDate { get; set; }
        [Column("Edi Count")]
        public int? EdiCount { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Instruction To Depot")]
        [StringLength(1000)]
        public string? InstructionToDepot { get; set; }
        [Column("Organisation Code")]
        [StringLength(10)]
        public string OrganisationCode { get; set; } = null!;
        [Column("Port Of Loading Code")]
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [Column("Return Type")]
        [StringLength(2)]
        public string ReturnType { get; set; } = null!;
        [Column("Site Code")]
        [StringLength(50)]
        public string? SiteCode { get; set; }
        [Column("Trucker Code")]
        [StringLength(10)]
        public string? TruckerCode { get; set; }
        [Column("Trucker Name")]
        [StringLength(80)]
        public string? TruckerName { get; set; }
        [Column("Trucker Ref No")]
        [StringLength(50)]
        public string? TruckerRefNo { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
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
