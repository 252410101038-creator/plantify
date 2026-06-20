namespace plantify.Models
{
    public abstract class User //abstract class untuk user umum, nanti akan diinherit oleh Customer dan Admin
    {
        // Private Fields
        private int id;
        private string username;
        private string email;
        private string password;

        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    username = value;
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Contains("@"))
                {
                    email = value;
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 8)
                {
                    password = value;
                }
            }
        }

        // Constructor
        public User()
        {

        }

        // Abstract Method
        public abstract string GetRole();
    }
}