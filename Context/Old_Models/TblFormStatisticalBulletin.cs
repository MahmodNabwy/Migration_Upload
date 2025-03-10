﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblForm_StatisticalBulletin")]
public partial class TblFormStatisticalBulletin
{
    [Key]
    [Column("FB_ID")]
    public int FbId { get; set; }

    [Column("FC_ID")]
    public int? FcId { get; set; }

    [Column("SB_ID")]
    public int? SbId { get; set; }

    [ForeignKey("FcId")]
    [InverseProperty("TblFormStatisticalBulletins")]
    public virtual TblFormCategory Fc { get; set; }

    [ForeignKey("SbId")]
    [InverseProperty("TblFormStatisticalBulletins")]
    public virtual TblStatisticsBulltin Sb { get; set; }
}