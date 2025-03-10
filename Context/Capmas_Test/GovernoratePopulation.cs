﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("governorate_population")]
[Index("GovernorateId", Name = "IX_governorate_population_governorate_id")]
public partial class GovernoratePopulation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("governorate_id")]
    public long GovernorateId { get; set; }

    [Column("population")]
    public double Population { get; set; }

    [Column("population_density")]
    public double PopulationDensity { get; set; }

    [Column("date")]
    public DateTime Date { get; set; }

    [ForeignKey("GovernorateId")]
    [InverseProperty("GovernoratePopulations")]
    public virtual Governorate Governorate { get; set; }
}