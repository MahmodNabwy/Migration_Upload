﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("journal_category_translations")]
[Index("JournalismCategoryId", "Locale", Name = "IX_journal_category_translations_journalism_category_id_locale", IsUnique = true)]
public partial class JournalCategoryTranslation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("locale")]
    [StringLength(6)]
    public string Locale { get; set; }

    [Required]
    public string JournalName { get; set; }

    [Column("journalism_category_id")]
    public long JournalismCategoryId { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("JournalismCategoryId")]
    [InverseProperty("JournalCategoryTranslations")]
    public virtual JournalCategory JournalismCategory { get; set; }
}