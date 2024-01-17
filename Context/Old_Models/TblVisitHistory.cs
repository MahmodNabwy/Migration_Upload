﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblVisit_History")]
public partial class TblVisitHistory
{
    [Key]
    [Column("Visit_History_ID")]
    public int VisitHistoryId { get; set; }

    [Column("Visit_History_IPAddress")]
    [StringLength(50)]
    public string VisitHistoryIpaddress { get; set; }

    [Column("Visit_History_LoginDate", TypeName = "datetime")]
    public DateTime? VisitHistoryLoginDate { get; set; }

    [Column("Visit_History_logoutDate", TypeName = "datetime")]
    public DateTime? VisitHistoryLogoutDate { get; set; }

    [Column("Visit_History_Count")]
    public int? VisitHistoryCount { get; set; }

    [Column("user_Id")]
    public int? UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("TblVisitHistories")]
    public virtual TblUser User { get; set; }
}