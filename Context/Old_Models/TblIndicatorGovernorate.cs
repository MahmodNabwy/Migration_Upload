﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblIndicatorGovernorates")]
public partial class TblIndicatorGovernorate
{
    [Key]
    [Column("Gov_ID")]
    public int GovId { get; set; }

    [Column("Gov_NameAr")]
    [StringLength(100)]
    public string GovNameAr { get; set; }

    [Column("Gov_NameEn")]
    [StringLength(100)]
    public string GovNameEn { get; set; }

    [Column("Gov_Code")]
    [StringLength(50)]
    public string GovCode { get; set; }
}