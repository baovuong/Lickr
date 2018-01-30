
using Lickr.Models;

namespace Lickr.Dispensers
{
    public interface ISongDispenser
    {
        Song Dispense();
        void AddSong(Song song);
        void AcceptSong(long id);
    }
}