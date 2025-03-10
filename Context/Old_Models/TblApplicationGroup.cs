﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Keyless]
[Table("tblApplication_Groups")]
public partial class TblApplicationGroup
{
    [Column("Group_ID")]
    public int GroupId { get; set; }

    [Column("Group_No")]
    public int? GroupNo { get; set; }

    [Column("Gov_ID")]
    public int? GovId { get; set; }

    [Column("Group_Date", TypeName = "datetime")]
    public DateTime? GroupDate { get; set; }

    [Column("Group_Location")]
    [StringLength(150)]
    public string GroupLocation { get; set; }
}