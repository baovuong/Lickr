using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lickr.Models;
using Lickr.SongHandlers;


namespace Lickr.Helpers
{
    public static class HtmlExtensions 
    {
        public static IHtmlContent SongDisplayFor(this IHtmlHelper html, Song song)
        {
            ISongHandler handler;
            switch (song.Type)
            {
                case SourceType.YOUTUBE:
                    handler = new YoutubeSongHandler();
                    break;
                default:
                    handler = null;
                    break;
            }
            return handler?.Present(html, song);
        }
    }
}