﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("happening_now_translations")]
[Index("HappeningNowId", "Locale", Name = "IX_happening_now_translations_happening_now_id_locale", IsUnique = true)]
public partial class HappeningNowTranslation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("title")]
    public string Title { get; set; }

    [Column("content")]
    public string Content { get; set; }

    [Required]
    [Column("locale")]
    [StringLength(6)]
    public string Locale { get; set; }

    [Column("happening_now_id")]
    public long HappeningNowId { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("HappeningNowId")]
    [InverseProperty("HappeningNowTranslations")]
    public virtual HappeningNow HappeningNow { get; set; }
}