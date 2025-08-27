using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmjm6
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Cargo Status Code")]
        [StringLength(3)]
        public string? CargoStatusCode { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Driver No")]
        [StringLength(45)]
        public string? DriverNo { get; set; }
        [Column("Ready Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ReadyDateTime { get; set; }
        [Column("Recevie Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? RecevieDateTime { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Seal No")]
        [StringLength(30)]
        public string? SealNo { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Truck Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? TruckDateTime { get; set; }
        [Column("UnLoad Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UnLoadDateTime { get; set; }
        [Column("Vehicle No")]
        [StringLength(50)]
        public string? VehicleNo { get; set; }
    }
}
