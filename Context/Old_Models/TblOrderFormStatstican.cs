﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblOrderFormStatsticans")]
public partial class TblOrderFormStatstican
{
    [Key]
    [Column("ROST_ID")]
    public int RostId { get; set; }

    [Column("ROST_CreatedDate", TypeName = "datetime")]
    public DateTime? RostCreatedDate { get; set; }

    [Column("ROST_StName")]
    [StringLength(100)]
    public string RostStName { get; set; }

    [Column("ROST_Clarify")]
    [StringLength(100)]
    public string RostClarify { get; set; }

    [Column("ROST_Employment")]
    [StringLength(100)]
    public string RostEmployment { get; set; }

    [Column("ROST_Addreess")]
    [StringLength(250)]
    public string RostAddreess { get; set; }

    [Column("ROST_PhoneNo")]
    [StringLength(50)]
    public string RostPhoneNo { get; set; }

    [Column("ROST_MobileNo")]
    [StringLength(50)]
    public string RostMobileNo { get; set; }

    [Column("ROST_FaxNo")]
    [StringLength(50)]
    public string RostFaxNo { get; set; }

    [Column("ROST_EMail")]
    [StringLength(50)]
    public string RostEmail { get; set; }

    [Column("ROST_SideName")]
    [StringLength(100)]
    public string RostSideName { get; set; }

    [Column("ROST_RequestOrder")]
    [StringLength(150)]
    public string RostRequestOrder { get; set; }

    [Column("ROST_OrderGoal")]
    [StringLength(250)]
    public string RostOrderGoal { get; set; }

    [Column("ROST_OrderSide")]
    [StringLength(50)]
    public string RostOrderSide { get; set; }

    [Column("ROST_UserID")]
    public int? RostUserId { get; set; }
}