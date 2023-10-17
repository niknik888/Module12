using System;


namespace Task1215
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Login: ");
            user.Login = Console.ReadLine();

            Console.WriteLine("Name: ");
            user.Name = Console.ReadLine();

            Console.WriteLine("Do you want to buy Premium? (input true or false) ");
            user.IsPremium = bool.Parse(Console.ReadLine());

            if (user.IsPremium == false) 
            {
                Ad.ShowAds();
            }

            Console.WriteLine($"Hello, {user.Name}");
        }
    }
}