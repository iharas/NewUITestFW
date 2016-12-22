namespace NewUITestFW.Domain
{
    public class User
    {
        public string Name { get; internal set; }
        public string Password { get; internal set; }
    }

    class UserBuilder
    {
        private readonly User _user;

        public UserBuilder()
        {
            _user = new User();
        }
        public UserBuilder SetName(string name)
        {
            _user.Name = name;
            return this;
        }

        public UserBuilder SetPass(string pass)
        {
            _user.Password = pass;
            return this;
        }

        public User Build()
        {
            return _user;
        }
    }
}
