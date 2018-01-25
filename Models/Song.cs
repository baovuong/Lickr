using System;

namespace Lickr.Models
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Source { get; set; }
        public SourceType Type { get; set; }
    }
}