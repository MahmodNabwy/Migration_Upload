﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("IndicatorsUsers_Priviliages")]
public partial class IndicatorsUsersPriviliage
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("Ind_ID")]
    public int? IndId { get; set; }

    [ForeignKey("IndId")]
    [InverseProperty("IndicatorsUsersPriviliages")]
    public virtual TblIndicator Ind { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("IndicatorsUsersPriviliages")]
    public virtual IndicatorsUser User { get; set; }
}