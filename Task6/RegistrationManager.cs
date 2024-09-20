namespace Task6;
/*
 * Завдання 6
 *
 * Напишіть консольну програму, яка дозволяє користувачеві
 * зареєструватися під «Логіном», що складається тільки з
 * символів латинського алфавіту, і пароля, що складається
 * з цифр і символів.
 */

public class RegistrationManager
{
    private LoginValidator loginValidator = new LoginValidator();
    
    // Метод для реєстрації користувача
    public void RegisterUser()
    {
        Console.WriteLine("Введіть логін (тільки латинські літери): ");
        string login = Console.ReadLine();
        
        // Перевірка логіну
        if (!loginValidator.IsValidLogin(login))
        {
            Console.WriteLine("Невірний формат логіну. Логін повинен містити тільки латинські літери.");
            return;
        }

        Console.WriteLine("Введіть пароль (цифри і символи):");
        string password = Console.ReadLine();
        
        // Перевірка пароля
        if (!loginValidator.IsValidPassword(password))
        {
            Console.WriteLine("Невірний формат пароля. Пароль повинен містити цифри та символи.");
            return;
        }
        
        // Якщо логін і пароль валідні, реєстрація успішна
        Console.WriteLine("Реєстрація успішна!");
    }
}