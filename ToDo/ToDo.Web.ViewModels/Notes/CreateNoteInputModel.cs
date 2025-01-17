﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDo.Web.ViewModels.Notes
{
    public class CreateNoteInputModel
    {
        [Required]
        [MinLength(3), MaxLength(50)]
        [Display(Name = "Title:")]
        public string Title { get; set; }

        [Required]
        [MinLength(5), MaxLength(350)]
        [Display(Name = "Description:")]
        public string Description { get; set; }

        [Display(Name = "Expires on:")]
        public DateTime ExpiredOn { get; set; }

        [Required]
        [Display(Name = "Category name:")]
        public int CategoryId { get; set; }
    }
}
