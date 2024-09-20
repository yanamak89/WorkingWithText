namespace Task3;

public class FileReader
{
    public string ReadFile(string filePath)
    {
        try
        {
            return File.ReadAllText(filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Помилка при читанні файлу {e.Message}");
            return string.Empty;
        }
    }
}