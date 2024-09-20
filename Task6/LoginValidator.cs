using System.Text.RegularExpressions;

namespace Task6;

/*
 * Завдання 6
 *
 * Напишіть консольну програму, яка дозволяє користувачеві
 * зареєструватися під «Логіном», що складається тільки з
 * символів латинського алфавіту, і пароля, що складається
 * з цифр і символів.
 */

public class LoginValidator
{
    // Метод для перевірки логіну (тільки латинські літери)
    public bool IsValidLogin(string login)
    {
        // Логін повинен містити тільки латинські літери
        return Regex.IsMatch(login, "^[a-zA-Z]+$");

    }
    
    // Метод для перевірки пароля (цифри і символи)
    public bool IsValidPassword(string password)
    {
        bool containsLetter = Regex.IsMatch(password, "[a-zA-Z]"); // Латинські літери
        bool containsDigit = Regex.IsMatch(password, "[0-9]"); // Цифри або спеціальні символи
        return containsLetter && containsDigit;
    }

}
