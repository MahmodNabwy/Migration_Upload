﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblDisscutionTopic")]
public partial class TblDisscutionTopic
{
    [Key]
    [Column("DT_ID")]
    public int DtId { get; set; }

    [Column("DT_Title")]
    [StringLength(100)]
    public string DtTitle { get; set; }

    [Column("DT_Details", TypeName = "text")]
    public string DtDetails { get; set; }

    [Column("DT_StartDate", TypeName = "datetime")]
    public DateTime? DtStartDate { get; set; }

    [Column("DT_EndDate", TypeName = "datetime")]
    public DateTime? DtEndDate { get; set; }

    [Column("Usr_ID")]
    public int UsrId { get; set; }

    [Column("DT_IsVisible")]
    public bool? DtIsVisible { get; set; }

    [Column("DT_IsClosed")]
    public bool? DtIsClosed { get; set; }

    [Column("Emp_ID")]
    public int? EmpId { get; set; }

    public bool? ShowInMain { get; set; }

    [Column("DT_Title_Eng")]
    [StringLength(100)]
    public string DtTitleEng { get; set; }

    [Column("DT_Details_Eng", TypeName = "text")]
    public string DtDetailsEng { get; set; }

    [ForeignKey("EmpId")]
    [InverseProperty("TblDisscutionTopics")]
    public virtual TblEmployee Emp { get; set; }

    [InverseProperty("Dt")]
    public virtual ICollection<TblUsersAnswer> TblUsersAnswers { get; set; } = new List<TblUsersAnswer>();

    [ForeignKey("UsrId")]
    [InverseProperty("TblDisscutionTopics")]
    public virtual TblUser Usr { get; set; }
}