﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Keyless]
[Table("gis_kism_data")]
public partial class GisKismDatum
{
    [Column("OBJECTID")]
    public int Objectid { get; set; }

    [Column("gov_code")]
    [StringLength(50)]
    public string GovCode { get; set; }

    [Column("pop_no")]
    public double? PopNo { get; set; }

    [Column("birth_no")]
    public double? BirthNo { get; set; }

    [Column("death_no")]
    public double? DeathNo { get; set; }

    [Column("mar_no")]
    public double? MarNo { get; set; }

    [Column("devor_no")]
    public double? DevorNo { get; set; }

    [Column("un_employ_no")]
    public double? UnEmployNo { get; set; }

    [Column("work_injur_no")]
    public double? WorkInjurNo { get; set; }

    [Column("wages")]
    public double? Wages { get; set; }

    [Column("work_hours")]
    public double? WorkHours { get; set; }

    [Column("trading_ersta_all")]
    public double? TradingErstaAll { get; set; }

    [Column("trading_estab_part")]
    public double? TradingEstabPart { get; set; }

    [Column("iron_factories_no")]
    public double? IronFactoriesNo { get; set; }

    [Column("asmant_factories_no")]
    public double? AsmantFactoriesNo { get; set; }

    [Column("home_device_factories")]
    public double? HomeDeviceFactories { get; set; }

    [Column("electric_station_no")]
    public double? ElectricStationNo { get; set; }

    [Column("tourist_arrivals_no")]
    public double? TouristArrivalsNo { get; set; }

    [Column("tourist_departing_no")]
    public double? TouristDepartingNo { get; set; }

    [Column("tourist_days_no")]
    public double? TouristDaysNo { get; set; }

    [Column("hospitals_no")]
    public double? HospitalsNo { get; set; }

    [Column("ambulance_no")]
    public double? AmbulanceNo { get; set; }

    [Column("clubs_no")]
    public double? ClubsNo { get; set; }

    [Column("NOG_no")]
    public double? NogNo { get; set; }

    [Column("water_amount")]
    public double? WaterAmount { get; set; }

    [Column("residenttial_units")]
    public double? ResidenttialUnits { get; set; }

    [Column("beaches_no")]
    public double? BeachesNo { get; set; }

    [Column("parks_no")]
    public double? ParksNo { get; set; }

    [Column("garbage_w")]
    public double? GarbageW { get; set; }

    [Column("ponds_no")]
    public double? PondsNo { get; set; }

    [Column("tape_no")]
    public double? TapeNo { get; set; }

    [Column("lamps_no")]
    public double? LampsNo { get; set; }

    [Column("markets_no")]
    public double? MarketsNo { get; set; }

    [Column("vehicles_no")]
    public double? VehiclesNo { get; set; }

    [Column("schools_no")]
    public double? SchoolsNo { get; set; }

    [Column("universities_no")]
    public double? UniversitiesNo { get; set; }

    [Column("institutes_no")]
    public double? InstitutesNo { get; set; }

    [Column("class_capasity")]
    public double? ClassCapasity { get; set; }

    [Column("crop_area")]
    public double? CropArea { get; set; }

    [Column("cultivated_area")]
    public double? CultivatedArea { get; set; }

    [Column("crops")]
    public double? Crops { get; set; }

    [Column("water_used")]
    public double? WaterUsed { get; set; }

    [Column("cattle")]
    public double? Cattle { get; set; }

    [Column("crops_production")]
    public double? CropsProduction { get; set; }

    [Column("POP_15")]
    public double? Pop15 { get; set; }

    [Column("POP_49")]
    public double? Pop49 { get; set; }

    [Column("POP_65")]
    public double? Pop65 { get; set; }

    [Column("hotels_no")]
    public double? HotelsNo { get; set; }

    [Column("garbage_q")]
    public double? GarbageQ { get; set; }

    [Column("sec_code")]
    [StringLength(4)]
    public string SecCode { get; set; }
}