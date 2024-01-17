﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("calendar_type_translations")]
[Index("CalendarTypeId", Name = "IX_calendar_type_translations_calendar_type_id")]
[Index("Locale", "CalendarTypeId", Name = "IX_calendar_type_translations_locale_calendar_type_id", IsUnique = true)]
public partial class CalendarTypeTranslation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("type")]
    public string Type { get; set; }

    [Required]
    [Column("locale")]
    [StringLength(6)]
    public string Locale { get; set; }

    [Column("calendar_type_id")]
    public long CalendarTypeId { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("CalendarTypeId")]
    [InverseProperty("CalendarTypeTranslations")]
    public virtual CalendarType CalendarType { get; set; }
}