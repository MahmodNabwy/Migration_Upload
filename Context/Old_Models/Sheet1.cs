﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Keyless]
[Table("Sheet1$")]
public partial class Sheet1
{
    [Column("HCA_ID")]
    public double? HcaId { get; set; }

    [Column("HCS_ID")]
    public double? HcsId { get; set; }

    [Column("HCA_StatusAr")]
    [StringLength(255)]
    public string HcaStatusAr { get; set; }

    [Column("HCA_StatusEn")]
    [StringLength(255)]
    public string HcaStatusEn { get; set; }

    [Column("HCA_StatYear")]
    [StringLength(255)]
    public string HcaStatYear { get; set; }

    [Column("HCA_Image")]
    [StringLength(255)]
    public string HcaImage { get; set; }

    [Column("HCA_PDFAr")]
    [StringLength(255)]
    public string HcaPdfar { get; set; }

    [Column("HCA_PDFEn")]
    [StringLength(255)]
    public string HcaPdfen { get; set; }

    [Column("Per_ID")]
    public double? PerId { get; set; }

    [Column("HCA_HasGov")]
    public double? HcaHasGov { get; set; }

    [Column("Gov_ID")]
    [StringLength(255)]
    public string GovId { get; set; }

    [Column("Year_ID")]
    public double? YearId { get; set; }

    [Column("Month_ID")]
    [StringLength(255)]
    public string MonthId { get; set; }

    [Column("Qua_ID")]
    [StringLength(255)]
    public string QuaId { get; set; }

    [Column("Emp_Create")]
    public double? EmpCreate { get; set; }

    [Column("Emp_Last_Update")]
    public double? EmpLastUpdate { get; set; }

    [Column("Emp_Update_Date", TypeName = "datetime")]
    public DateTime? EmpUpdateDate { get; set; }

    [Column("Status_Order")]
    public double? StatusOrder { get; set; }
}