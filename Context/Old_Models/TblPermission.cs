﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblPermission")]
public partial class TblPermission
{
    [Key]
    [Column("PerID")]
    public int PerId { get; set; }

    public bool? CanInsert { get; set; }

    public bool? CanEdit { get; set; }

    public bool? CanDelete { get; set; }

    [Column("EmpGr_ID")]
    public int? EmpGrId { get; set; }

    [Column("AM_ID")]
    public int? AmId { get; set; }

    [Column("MSM_ID")]
    public int? MsmId { get; set; }

    [Column("Per_SubPage")]
    public bool? PerSubPage { get; set; }

    [Column("Per_CheckBox")]
    public bool? PerCheckBox { get; set; }

    [ForeignKey("AmId")]
    [InverseProperty("TblPermissions")]
    public virtual TblAdminMenu Am { get; set; }

    [ForeignKey("EmpGrId")]
    [InverseProperty("TblPermissions")]
    public virtual TblEmployeesGroup EmpGr { get; set; }

    [ForeignKey("MsmId")]
    [InverseProperty("TblPermissions")]
    public virtual TblMainSubMenu Msm { get; set; }
}