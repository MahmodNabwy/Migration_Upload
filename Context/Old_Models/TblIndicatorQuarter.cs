﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblIndicatorQuarter")]
public partial class TblIndicatorQuarter
{
    [Key]
    [Column("Qurt_ID")]
    public int QurtId { get; set; }

    [Column("Qurt_NameAr")]
    [StringLength(20)]
    public string QurtNameAr { get; set; }

    [Column("Qurt_NameEn")]
    [StringLength(20)]
    public string QurtNameEn { get; set; }
}