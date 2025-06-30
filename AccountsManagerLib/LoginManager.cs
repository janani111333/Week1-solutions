namespace AccountsManagerLib
{
    public class LoginManager
    {
        private readonly Dictionary<string, string> validUsers = new Dictionary<string, string>
        {
            { "user_11", "secret@user11" },
            { "user_22", "secret@user22" }
        };

        public string Login(string userId, string password)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("User ID and password must not be empty.");

            if (validUsers.ContainsKey(userId) && validUsers[userId] == password)
                return $"Welcome {userId}!!!";

            return "Invalid user id/password";
        }
    }
}
