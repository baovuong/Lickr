using System;
using System.ComponentModel.DataAnnotations;

namespace Lickr.Models
{
    public class SongSubmissionViewModel
    {
        [Required]
        public string Source { get; set; }

        [Required]
        public TimeSpan Start { get; set; }

        [Required]
        public TimeSpan End { get; set; }
    }
}