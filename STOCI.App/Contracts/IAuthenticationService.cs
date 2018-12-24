using System;
using System.Threading.Tasks;

namespace STOCI.App
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> Register(string firstName, string lastName, string email, string userName,
            string password);

        Task<AuthenticationResponse> Authenticate(string userName, string password);

        bool IsUserAuthenticated();
    }
}
