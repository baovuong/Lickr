using System;

namespace Lickr.Models
{
    public class SongViewModel
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Source { get; set; }
        public string SourceType { get; set; }
    }
}