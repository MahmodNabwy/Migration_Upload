﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblResearchsAndForms")]
public partial class TblResearchsAndForm
{
    [Key]
    [Column("Rch_ID")]
    public int RchId { get; set; }

    [Column("Rch_TitleAr")]
    [StringLength(500)]
    public string RchTitleAr { get; set; }

    [Column("Rch_TitleEn")]
    [StringLength(500)]
    public string RchTitleEn { get; set; }

    [Column("Rch_IconLink")]
    [StringLength(200)]
    public string RchIconLink { get; set; }

    [Column("RC_ID")]
    public int? RcId { get; set; }

    [Column("Emp_Create")]
    public int? EmpCreate { get; set; }

    [Column("Emp_Last_Update")]
    public int? EmpLastUpdate { get; set; }

    [Column("Emp_Update_Date", TypeName = "datetime")]
    public DateTime? EmpUpdateDate { get; set; }

    [ForeignKey("EmpCreate")]
    [InverseProperty("TblResearchsAndFormEmpCreateNavigations")]
    public virtual TblEmployee EmpCreateNavigation { get; set; }

    [ForeignKey("EmpLastUpdate")]
    [InverseProperty("TblResearchsAndFormEmpLastUpdateNavigations")]
    public virtual TblEmployee EmpLastUpdateNavigation { get; set; }

    [ForeignKey("RcId")]
    [InverseProperty("TblResearchsAndForms")]
    public virtual TblReseachAndFormsCategory Rc { get; set; }

    [InverseProperty("Rch")]
    public virtual ICollection<TblReserchesAndFormsYear> TblReserchesAndFormsYears { get; set; } = new List<TblReserchesAndFormsYear>();

    [InverseProperty("Rch")]
    public virtual ICollection<TblUserFav> TblUserFavs { get; set; } = new List<TblUserFav>();
}