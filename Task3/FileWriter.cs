namespace Task3;

public class FileWriter
{
    // Метод для запису тексту у файл
    public void WriteFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
    }
}