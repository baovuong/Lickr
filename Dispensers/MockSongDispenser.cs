using System;
using Lickr.Models;

namespace Lickr.Dispensers
{
    public class MockSongDispenser : ISongDispenser
    {
        public Song Dispense() => new Song 
        {
            Title = "7:00 AM",
            Artist = "Tennyson", 
            Start = new DateTime(1, 1, 1, 1, 52, 0),
            End = new DateTime(1, 1, 1, 1, 59, 0),
            Source = "https://www.youtube.com/watch?v=kLIy9wxWCh8",
            Type = SourceType.YOUTUBE
        };
    }
}