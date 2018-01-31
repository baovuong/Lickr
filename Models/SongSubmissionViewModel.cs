using System;
using System.ComponentModel.DataAnnotations;

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
    }
}