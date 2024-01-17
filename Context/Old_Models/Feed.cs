﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

public partial class Feed
{
    [Key]
    public Guid Id { get; set; }

    public int ChannelId { get; set; }

    [Required]
    [StringLength(200)]
    [Unicode(false)]
    public string Title { get; set; }

    [Required]
    [StringLength(1000)]
    [Unicode(false)]
    public string Description { get; set; }

    [Required]
    [StringLength(200)]
    public string Link { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PublishedDate { get; set; }

    [ForeignKey("ChannelId")]
    [InverseProperty("Feeds")]
    public virtual Channel Channel { get; set; }
}