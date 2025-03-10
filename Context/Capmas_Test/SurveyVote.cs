﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("survey_vote")]
[Index("SurveyId", Name = "IX_survey_vote_survey_id")]
public partial class SurveyVote
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("insert_date")]
    public DateTime InsertDate { get; set; }

    [Column("survey_id")]
    public long SurveyId { get; set; }

    [ForeignKey("SurveyId")]
    [InverseProperty("SurveyVotes")]
    public virtual Survey Survey { get; set; }

    [InverseProperty("SurveyVote")]
    public virtual ICollection<SurveyQuestionOptionVote> SurveyQuestionOptionVotes { get; set; } = new List<SurveyQuestionOptionVote>();
}