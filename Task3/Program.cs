using Task3;

class Program
{
    public static void Main(string[] args)
    {
        // Створюємо екземпляри класів
        FileReader fileReader = new FileReader();
        FileWriter fileWriter = new FileWriter();
        Deshifrator deshifrator = new Deshifrator();

        try
        {
            // Шляхи до файлів
            string inputFilePath = "input.txt";
            string outputFilePath = "ouput.txt";
            
            // Читання тексту з файлу
            string text = fileReader.ReadFile(inputFilePath);
            
            // Дешифруємо текст
            string decodedText = deshifrator.DecodeText(text);
            
            // Записуємо результат у новий файл
            fileWriter.WriteFile(outputFilePath, decodedText);

            Console.WriteLine("Дешифрування завершено. Результат записано у файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Виникла помилка: {ex.Message}");
            
        }
    }
}