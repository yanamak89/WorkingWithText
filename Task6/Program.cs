/*
 * Завдання 6
 *
 * Напишіть консольну програму, яка дозволяє користувачеві
 * зареєструватися під «Логіном», що складається тільки з
 * символів латинського алфавіту, і пароля, що складається
 * з цифр і символів.
 */


using Task6;

class Program
{
    public static void Main(string[] args)
    {
        RegistrationManager registrationManager = new RegistrationManager();
        registrationManager.RegisterUser();
    }
}