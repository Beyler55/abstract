namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Email = "Baylar@code",
                FullName = "Baylar Sadiqov"
            };
            user.ShowInfo();

        }

    }
}

