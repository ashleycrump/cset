﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSETWebCore.DataLayer.Model
{
    public partial class MATURITY_LEVEL_USAGE_TYPES
    {
        public MATURITY_LEVEL_USAGE_TYPES()
        {
            MATURITY_MODELS = new HashSet<MATURITY_MODELS>();
        }

        [Key]
        [StringLength(50)]
        public string Maturity_Level_Usage_Type { get; set; }

        [InverseProperty("Maturity_Level_Usage_TypeNavigation")]
        public virtual ICollection<MATURITY_MODELS> MATURITY_MODELS { get; set; }
    }
}