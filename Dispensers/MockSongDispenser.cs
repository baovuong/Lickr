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
                    Start = new TimeSpan(0, 1, 52),
                    End = new TimeSpan(0, 1, 59),
                    Source = "https://www.youtube.com/watch?v=kLIy9wxWCh8",
                    Type = SourceType.YOUTUBE
                },

                new Song
                {
                    Title = "Spain",
                    Artist = "Chick Corea and Return to Forever",
                    Start = new TimeSpan(0, 6, 11),
                    End = new TimeSpan(0, 6, 15),
                    Source = "https://www.youtube.com/watch?v=a_OEJ0wqt2g",
                    Type = SourceType.YOUTUBE
                },

                new Song
                {
                    Title = "Mario Circuit",
                    Artist = "Super Soul Bros.",
                    Start = new TimeSpan(0, 2, 56),
                    End = new TimeSpan(0, 3, 2),
                    Source = "https://www.youtube.com/watch?v=02merJLHgNg",
                    Type = SourceType.YOUTUBE
                }
            };

        }
        public Song Dispense() => songs.OrderBy(a => Guid.NewGuid()).First();

        public void AddSong(Song song) {}
        public void AcceptSong(long id) {}
    }
}