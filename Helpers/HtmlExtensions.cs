using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lickr.Models;
using Lickr.SongHandlers;


namespace Lickr.Helpers
{
    public static class HtmlExtensions 
    {
        public static IHtmlContent SongDisplayFor(
            this IHtmlHelper html, 
            Song song, 
            Func<SourceType, ISongHandler> handlerResolver) => handlerResolver(song.Type).Present(html, song);
    }
}