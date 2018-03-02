using System;
using Lickr.Models;

namespace Lickr.GateKeepers
{
    public interface IGateKeeper
    {
        string Authenticate(string username, string password);
        bool Deauthenticate(string sessionToken);
        UserRole GetUserRole(string sessionToken);
    }
}