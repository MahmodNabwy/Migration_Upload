﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("event_type_translations")]
[Index("EventTypeId", "Locale", Name = "IX_event_type_translations_event_type_id_locale", IsUnique = true)]
public partial class EventTypeTranslation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("name")]
    public string Name { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("event_type_id")]
    public long EventTypeId { get; set; }

    [Required]
    [Column("locale")]
    [StringLength(6)]
    public string Locale { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("EventTypeId")]
    [InverseProperty("EventTypeTranslations")]
    public virtual EventType EventType { get; set; }
}