namespace Task2;

public class ResultSaver
{
    public void SaveToFile(string filePath, string[] links, string[] emails, string[] phoneNumbers)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Посилання: ");
            foreach (var link in links)
            {
                writer.WriteLine(link);
            }

            writer.WriteLine("\nПоштові адреси");
            foreach (var email in emails)
            {
                writer.WriteLine(email);
            }

           writer.WriteLine("\nНомери телефонів: ");
           foreach (var phone in phoneNumbers)
           {
               writer.WriteLine(phone);
           }
        }
    }
}