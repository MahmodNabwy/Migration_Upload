﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("journal_category")]
[Index("JournalName", Name = "IX_journal_category_JournalName", IsUnique = true)]
public partial class JournalCategory
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    public string JournalName { get; set; }

    [Column("thumbnail")]
    public string Thumbnail { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [Column("status")]
    public int? Status { get; set; }

    [Column("is_published")]
    public bool IsPublished { get; set; }

    [Column("is_deleted")]
    public bool IsDeleted { get; set; }

    [Column("publish_date")]
    public DateTime? PublishDate { get; set; }

    [InverseProperty("JournalismCategory")]
    public virtual ICollection<JournalCategoryTranslation> JournalCategoryTranslations { get; set; } = new List<JournalCategoryTranslation>();

    [InverseProperty("JournalCategory")]
    public virtual ICollection<Journalism> Journalisms { get; set; } = new List<Journalism>();
}