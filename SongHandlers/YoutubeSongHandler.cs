using System;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lickr.Models;

namespace Lickr.SongHandlers
{
    public class YoutubeSongHandler : ISongHandler
    {
        private readonly Regex regex = new Regex("youtube.com\\/watch\\?v=(.*)");
        public IHtmlContent Present(IHtmlHelper html, Song song)
        {
            return html.Partial("SongDisplay/YoutubePartial", new YoutubeSongViewModel
            {
                VideoId = regex.Matches(song.Source).Cast<Match>().FirstOrDefault()?.Groups[1].Value,
                Start = song.Start.Minutes*60 + song.Start.Seconds,
                End = song.End.Minutes*60 + song.End.Seconds
            });
        }

        public bool Validate(Song song)
        {
            // TODO implement this
            throw new NotImplementedException();
        }

        public IHtmlContent SubmissionForm(IHtmlHelper html)
        {
            throw new NotImplementedException();
        }
    }
}