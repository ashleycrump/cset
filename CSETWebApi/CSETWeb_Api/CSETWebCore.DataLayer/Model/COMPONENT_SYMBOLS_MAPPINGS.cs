﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSETWebCore.DataLayer.Model;

public partial class COMPONENT_SYMBOLS_MAPPINGS
{
    [Key]
    public int Mapping_Id { get; set; }

    public int Component_Symbol_Id { get; set; }

    public string Application { get; set; }

    public string Malcolm_Role { get; set; }

    public virtual COMPONENT_SYMBOLS Component_Symbol { get; set; }
}