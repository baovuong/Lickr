using System;

namespace Lickr.GateKeepers
{
    public interface IGateKeeper
    {
        bool IsValid(string username, string password);
    }
}