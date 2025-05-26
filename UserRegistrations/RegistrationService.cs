namespace UserRegistrations
{
    public class RegistrationService
    {
        public bool Register(User user)
        {
            if (string.IsNullOrWhiteSpace(user.username))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(user.password) || user.password.Length < 6)
            {
                return false;
            }

            return true;
        }
            
    }
}
