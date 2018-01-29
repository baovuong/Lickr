using System;
using System.Linq;
using System.Collections.Generic;
using Lickr.Models;

namespace Lickr.Dispensers
{
    public class MockSongDispenser : ISongDispenser
    {
        private List<Song> songs;

        public MockSongDispenser() 
        {
            songs = new List<Song>
            {
                new Song         
                {
                    Title = "7:00 AM",
                    Artist = "Tennyson", 
                    Start = new DateTime(1,1,1,1, 1, 52),
                    End = new DateTime(1,1,1,1, 1, 59),
                    Source = "https://www.youtube.com/watch?v=kLIy9wxWCh8",
                    Type = SourceType.YOUTUBE
                },

                new Song
                {
                    Title = "Spain",
                    Artist = "Chick Corea and Return to Forever",
                    Start = new DateTime(1,1,1,1, 6, 11),
                    End = new DateTime(1,1,1,1, 6, 15),
                    Source = "https://www.youtube.com/watch?v=a_OEJ0wqt2g",
                    Type = SourceType.YOUTUBE
                }
            };

        }
        public Song Dispense() => songs.OrderBy(a => Guid.NewGuid()).First();
    }
}