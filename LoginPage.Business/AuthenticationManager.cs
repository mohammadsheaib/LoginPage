using LoginPage.EF;
namespace LoginPage.Business
{
    public class AuthenticationManager
    {
        AuthenticationEFDataManager _authenticationDataManager;

        public AuthenticationManager(AuthenticationEFDataManager authenticationDataManager)
        {
            _authenticationDataManager = authenticationDataManager;
        }

        public bool ValidateCredentials(string username, string password)
        {
            return _authenticationDataManager.ValidateCredentials(username, password);
        }
    }
}
