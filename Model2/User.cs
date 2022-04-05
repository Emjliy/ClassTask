using System;
using System.Collections.Generic;
using System.Text;

namespace Model2
{
    class User : IAccount
    {
        public string FullName;
        public string Email;
        public string Password;
        public User(string fullname, string email)
        {
            FullName = fullname;
            Email = email;
        }
        bool upper ;
        bool lower ;
        bool digit ;
        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        upper = true;
                    }
                    if (char.IsLower(password[i]))
                    {
                        lower = true;
                    }
                    if (char.IsDigit(password[i]))
                    {
                        digit = true;
                    }
                }
            }
            if (upper && lower && digit)
            {
                Password = password;
                Console.WriteLine("Right password created");
                return true;
            }
            else
            {
                Console.WriteLine("invalid password ");
            }
            return false;


        }
        public void ShowInfo()
        {
            Console.WriteLine($"{FullName} {Email}");
        }
    }
}
