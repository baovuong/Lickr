using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lickr.Models
{
    public class SongSubmissionViewModel
    {
        [Required]
        [Display(Name = "Source/URL")]
        public string Source { get; set; }

        [Required]
        [Display(Name = "Start Timestamp")]
        public TimeSpan Start { get; set; }

        [Required]
        [Display(Name = "End Timestamp")]
        public TimeSpan End { get; set; }

        [Display(Name = "Source Type")]
        public SourceType Type { get; set; }

        public IEnumerable<SelectListItem> SourceTypeItems { get; set; }
    }
}