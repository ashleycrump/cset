﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSETWebCore.DataLayer.Model2
{
    /// <summary>
    /// A collection of SECTOR_STANDARD_RECOMMENDATIONS records
    /// </summary>
    public partial class SECTOR_STANDARD_RECOMMENDATIONS
    {
        [Key]
        public int Sector_Id { get; set; }
        [Key]
        public int Industry_Id { get; set; }
        [Key]
        [StringLength(50)]
        public string Organization_Size { get; set; }
        [Key]
        [StringLength(50)]
        public string Asset_Value { get; set; }
        [Key]
        [StringLength(50)]
        public string Set_Name { get; set; }

        [ForeignKey(nameof(Sector_Id))]
        [InverseProperty(nameof(SECTOR.SECTOR_STANDARD_RECOMMENDATIONS))]
        public virtual SECTOR Sector { get; set; }
        [ForeignKey(nameof(Set_Name))]
        [InverseProperty(nameof(SETS.SECTOR_STANDARD_RECOMMENDATIONS))]
        public virtual SETS Set_NameNavigation { get; set; }
    }
}