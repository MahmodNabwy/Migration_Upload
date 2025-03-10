﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblUsersGroups_Bulltins")]
public partial class TblUsersGroupsBulltin
{
    [Key]
    [Column("UGB_ID")]
    public int UgbId { get; set; }

    [Column("UsrGrp_ID")]
    public int? UsrGrpId { get; set; }

    [Column("SB_ID")]
    public int? SbId { get; set; }

    [Column("Emp_Create")]
    public int? EmpCreate { get; set; }

    [Column("Emp_Last_Update")]
    public int? EmpLastUpdate { get; set; }

    [Column("Emp_Update_Date", TypeName = "datetime")]
    public DateTime? EmpUpdateDate { get; set; }

    [ForeignKey("EmpCreate")]
    [InverseProperty("TblUsersGroupsBulltinEmpCreateNavigations")]
    public virtual TblEmployee EmpCreateNavigation { get; set; }

    [ForeignKey("EmpLastUpdate")]
    [InverseProperty("TblUsersGroupsBulltinEmpLastUpdateNavigations")]
    public virtual TblEmployee EmpLastUpdateNavigation { get; set; }

    [ForeignKey("SbId")]
    [InverseProperty("TblUsersGroupsBulltins")]
    public virtual TblStatisticsBulltin Sb { get; set; }

    [ForeignKey("UsrGrpId")]
    [InverseProperty("TblUsersGroupsBulltins")]
    public virtual TblUserGroup UsrGrp { get; set; }
}