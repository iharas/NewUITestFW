namespace NewUITestFW.Domain
{
    internal static class UserRepository
    {
        public static User GetAdminUser()
        {
            return new UserBuilder().SetName("admin").SetPass("admin").Build();
        }
    }
}
