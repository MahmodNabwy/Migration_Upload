﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblIndicatorOtherData")]
public partial class TblIndicatorOtherDatum
{
    [Key]
    [Column("OtherData_ID")]
    public int OtherDataId { get; set; }

    [Column("OtherData_NameAr")]
    [StringLength(200)]
    public string OtherDataNameAr { get; set; }

    [Column("OtherData_NameEn")]
    [StringLength(200)]
    public string OtherDataNameEn { get; set; }

    [Column("OtherDataCategory_ID")]
    public int? OtherDataCategoryId { get; set; }
}