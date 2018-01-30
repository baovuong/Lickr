using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lickr.Models;

namespace Lickr.SongHandlers
{
    public interface ISongHandler
    {
        IHtmlContent Present(IHtmlHelper html, Song song); 
        IHtmlContent SubmissionForm(IHtmlHelper html);
        bool Validate(Song song);
    }
}