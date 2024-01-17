﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblMessages")]
public partial class TblMessage
{
    [Key]
    [Column("Msg_ID")]
    public int MsgId { get; set; }

    [Column("Msg_Title")]
    [StringLength(50)]
    public string MsgTitle { get; set; }

    [Column("Msg_Content")]
    [StringLength(250)]
    public string MsgContent { get; set; }

    [InverseProperty("Msg")]
    public virtual ICollection<TblUseMessage> TblUseMessages { get; set; } = new List<TblUseMessage>();
}