﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDo.Web.ViewModels.Cities
{
    public class CityInputViewModel
    {
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }
    }
}
