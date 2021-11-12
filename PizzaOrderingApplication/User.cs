namespace PizzaOrderingApplication
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CanEditSizes { get; set; }
        public bool CanEditToppings { get; set; }
        public bool CanEditUsers { get; set; }

        public User()
        {
            // Default constructor
        }

        public User(string username, string password, bool canEditSizes, bool canEditToppings, bool canEditUsers)
        {
            Username = username;
            Password = password;
            CanEditSizes = canEditSizes;
            CanEditToppings = canEditToppings;
            CanEditUsers = canEditUsers;
        }
    }
}