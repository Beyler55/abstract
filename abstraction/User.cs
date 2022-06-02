using System;

namespace abstraction
{
    class User : IAccount
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            do
            {
                Console.WriteLine("Sifreni daxil edin:");
                Password = Console.ReadLine();
            }
            while (!PasswordChecker(Password));

        }

        public bool PasswordChecker(string password)
        {
            if (password.Length > 7)
            {
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        return true;
                    }
                    if (password == password.ToUpper() || password == password.ToLower())
                    {
                        return false;
                    }
                }

            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine(FullName);
            Console.WriteLine(Email);
        }
    }
}
