using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using SFDashboard.SFModels;

namespace SFDashboard.Models
{
   
    public class DashBoardDetails
    {
        [Key]
        [Column(TypeName = "nvarchar(20)")]
        public string DashBoardName { get; set; }
        [Key]
        [Column(TypeName = "nvarchar(30)")]
        public string Code { get; set; }
        [Key]
        [Column(TypeName = "nvarchar(30)")]
        public string code2 { get; set; }
        [Key]
        [Column(TypeName = "nvarchar(30)")]
        public string CustomerCode { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? Description { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string? Short { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? Long { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LabelName { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Type { get; set; }

 
        public int? Value { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Source { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? ServerName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? DBName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string? Schema { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string? TableName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string? LoginID { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string? Password { get; set; }
        [Column(TypeName = "nvarchar(4000)")]
        public string? Notes { get; set; }
        public DateTime CreateDateTime { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        public string CreateBy { get; set; }
        public DateTime UpdateDateTime { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        public string UpdateBy { get; set; }
        [Column(TypeName = "nvarchar(1)")]
        public string? ArchiveFlag { get; set; }
        [Timestamp]
        public byte[] TimeStamp { get; set; }
        [Column(TypeName = "nvarchar(4000)")]
        public string? Notes2 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string UDF01 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string UDF02 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string UDF03 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string UDF04 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string UDF05 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string? GraphData { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public string? Icon { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? IconSize { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? IconColor { get; set; }
        public string? SPParameter01 { get; set; }
        public string? SPParameter02 { get; set; }

        [NotMapped]
        public int dataCount { get; set; }
      
        [NotMapped]
        public int tabCode { get; set; }

       
        [NotMapped]
        public string? TabDescription { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [NotMapped]
        public List<string> ColumnName { get; set; }
        [NotMapped]
        public List<dynamic> RowField { get; set; }
        [NotMapped]
        public List<InformationBox> ListInformationBox { get; set; }
        [NotMapped]
        public List<GraphBox> ListGraphBoxs { get; set; }
        [NotMapped]
        public List<VwUserMenu> ListUserMenu { get; set; }
       
        public DashBoardDetails()
        {
            ListInformationBox = new List<InformationBox>();
            ListUserMenu = new List<VwUserMenu>();
            ColumnName = new List<string>();
            RowField = new List<dynamic>();
            ListGraphBoxs = new List<GraphBox>();
        }

        
    }
   
    public class InformationBox
    {
        public string? m_label { get; set; }
      
        public string? m_value { get; set; }
       
        public InformationBox(string? label, string? value)
        {
            this.m_label = label;
            this.m_value = value;
        }
    }
   
    public class GraphBox
    {
        public object? m_graphlabel { get; set; }
        public object? m_graphlegend { get; set; }
        public object? m_graphvalue { get; set; }
        public GraphBox(object? label, object? legend, object? value)
        {
            this.m_graphlabel = label;
            this.m_graphvalue = value;
            this.m_graphlegend = legend;
        }
    }
}
