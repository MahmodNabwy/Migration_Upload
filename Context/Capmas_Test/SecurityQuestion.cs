﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("security_questions")]
public partial class SecurityQuestion
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("question")]
    [StringLength(255)]
    public string Question { get; set; }

    [Column("question_ar")]
    [StringLength(255)]
    public string QuestionAr { get; set; }

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

    [InverseProperty("SecurityQuestion")]
    public virtual ICollection<UserSecurityQuestion> UserSecurityQuestions { get; set; } = new List<UserSecurityQuestion>();
}