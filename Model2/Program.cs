using System;

namespace Model2
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("Emilya","emilya.agayeva");
            u.Password = "emasdfg";
            u.PasswordChecker(u.Password);
            u.ShowInfo();

        }
    }
}   
