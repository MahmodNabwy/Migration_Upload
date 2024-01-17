﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblNewsTypes_MainSubMenu")]
public partial class TblNewsTypesMainSubMenu
{
    [Key]
    [Column("NTM_ID")]
    public int NtmId { get; set; }

    [Column("NTM_NameAr")]
    [StringLength(100)]
    public string NtmNameAr { get; set; }

    [Column("NTM_NameEn")]
    [StringLength(100)]
    public string NtmNameEn { get; set; }

    [Column("Type_ID")]
    public int TypeId { get; set; }

    [Column("MSM_ID")]
    public int? MsmId { get; set; }

    [Column("NTM_Order")]
    public int? NtmOrder { get; set; }

    [Column("Emp_Create")]
    public int? EmpCreate { get; set; }

    [Column("Emp_Last_Update")]
    public int? EmpLastUpdate { get; set; }

    [Column("Emp_Update_Date", TypeName = "datetime")]
    public DateTime? EmpUpdateDate { get; set; }

    [ForeignKey("EmpCreate")]
    [InverseProperty("TblNewsTypesMainSubMenuEmpCreateNavigations")]
    public virtual TblEmployee EmpCreateNavigation { get; set; }

    [ForeignKey("EmpLastUpdate")]
    [InverseProperty("TblNewsTypesMainSubMenuEmpLastUpdateNavigations")]
    public virtual TblEmployee EmpLastUpdateNavigation { get; set; }

    [ForeignKey("MsmId")]
    [InverseProperty("TblNewsTypesMainSubMenus")]
    public virtual TblMainSubMenu Msm { get; set; }

    [InverseProperty("Ntm")]
    public virtual ICollection<TblNews> TblNews { get; set; } = new List<TblNews>();

    [ForeignKey("TypeId")]
    [InverseProperty("TblNewsTypesMainSubMenus")]
    public virtual TblNewsType Type { get; set; }
}