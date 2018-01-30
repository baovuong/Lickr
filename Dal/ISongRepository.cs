using System;
using System.Collections.Generic;
using Lickr.Models;

namespace Lickr.Dal
{
    public interface ISongRepository
    {
        IEnumerable<SongViewModel> Songs { get; set; }
    }
}