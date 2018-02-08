using System;

namespace Lickr.Models
{
    public class Song
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public string Source { get; set; }
        public SourceType Type { get; set; }
        public bool Accepted { get; set; }
    }
}