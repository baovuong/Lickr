using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lickr.Models;

namespace Lickr.Presenters
{
    public interface IPresenter
    {
        IHtmlContent Present(IHtmlHelper html, Song song); 
    }
}