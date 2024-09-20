/*
 * Завдання 2
 * Напишіть програму, яка дозволила б за вказаною адресою web-сторінки
 * вибирати всі посилання на інші сторінки,
 *          номери телефонів,
 *          поштові адреси
 *          та зберігала отриманий результат у файл.
 */

using Task2;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://www.google.com/search?q=Aluminiowy+%22drewniany%22+naro%C5%BCnik+tarasowy+w+stylu+boho+Oluf+Cream+meblobranie&rlz=1C5CHFA_enPL989PL989&oq=Aluminiowy+%22drewniany%22+naro%C5%BCnik+tarasowy+w+stylu+boho+Oluf+Cream+meblobranie&gs_lcrp=EgZjaHJvbWUyBggAEEUYOdIBBzQyNmowajSoAgCwAgE&sourceid=chrome&ie=UTF-8"; // Замініть на потрібну адресу
        var fetcher = new WebPageFetcher();
        var parser = new ContentParser();
        var saver = new ResultSaver();

        string htmlContent = await fetcher.FetchPageContentAsync(url);
        
        if (!string.IsNullOrEmpty(htmlContent))
        {
            var links = parser.ExtractLinks(htmlContent);
            var emails = parser.ExtractEmails(htmlContent);
            var phoneNumbers = parser.ExtractPhoneNumbers(htmlContent);
            
            string filePath = "output.txt";
            saver.SaveToFile(filePath, links, emails, phoneNumbers);

            Console.WriteLine($"Дані збережено у файл: {filePath}");
        }
        else
        {
            Console.WriteLine("Не вдалося отримати вміст сторінки.");
        }
    }
}