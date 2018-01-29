using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lickr.Models;
using Lickr.Presenters;


namespace Lickr.Helpers
{
    public static class HtmlExtensions 
    {
        public static IHtmlContent SongDisplayFor(this IHtmlHelper html, Song song)
        {
            IPresenter presenter;
            switch (song.Type)
            {
                case SourceType.YOUTUBE:
                    presenter = new YoutubePresenter();
                    break;
                default:
                    presenter = null;
                    break;
            }
            return presenter?.Present(html, song);
        }
    }
}