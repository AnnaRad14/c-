using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            admin.UserName = "AdminUser";
            admin.Email = "admin@example.com";
            admin.SetPassword("admin123");

            Moderator moderator = new Moderator();
            moderator.UserName = "ModUser";
            moderator.Email = "mod@example.com";
            moderator.SetPassword("mod123");

            RegularUser regUser = new RegularUser();
            regUser.UserName = "RegUser";
            regUser.Email = "user@example.com";
            regUser.SetPassword("user123");

            List<User> users = new List<User>();
            users.Add(admin);
            users.Add(moderator);
            users.Add(regUser);

            Console.WriteLine("=== Інформація про користувачів ===");
            foreach (User u in users)
            {
                u.DisplayInfo();
            }

            Console.WriteLine("\n=== Тестування методів ===");

            if (admin is Admin)
            {
                admin.BlockUser(regUser);
            }

            if (moderator is Moderator)
            {
                moderator.ModerateContent();
            }

            if (regUser is RegularUser)
            {
                regUser.PostComment();
            }

            Console.WriteLine("\n=== Перевірка аутентифікації ===");

            if (admin.Authenticate("admin123"))
            {
                Console.WriteLine("AdminUser: Успішна аутентифікація");
            }

            if (!moderator.Authenticate("wrongpass"))
            {
                Console.WriteLine("ModUser: Невірний пароль");
            }

            if (regUser.Authenticate("user123"))
            {
                Console.WriteLine("RegUser: Успішна аутентифікація");
            }
        }
    }
}