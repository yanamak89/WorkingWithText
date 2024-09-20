namespace Task4;

/*
 * Завдання 4
   Створіть текстовий файл-чек на кшталт «Найменування товару –
    0.00(ціна)грн.» з певною кількістю найменувань товарів та
    датою здійснення покупки. Виведіть на екран інформацію з
    чека у форматі поточної локалі користувача та у форматі
    локалі en-US.
 */

public class ReceiptGenerator
{
    // Метод для створення файлу-чека
    public void CreateReceipt(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Дата покупки
            DateTime purchaseDate = DateTime.Now;
            
            // Декілька найменувань товарів з цінами
            string[] items = { "Хліб", "Молоко", "Яйця", "Сир", "Кава" };
            decimal[] prices = { 20.5m, 30.00m, 40.75m, 100.99m, 250.00m };
            
            // Записуємо заголовок з датою покупки
            writer.WriteLine($"Дата покупки: {purchaseDate}");
            
            // Записуємо список товарів з цінами
            for (int i = 0; i < items.Length; i++)
            {
                writer.WriteLine($"{items[i]} - {prices[i]:0.00} грн.");
            }
            
            writer.WriteLine("Дякуємо за покупку!");
        }
    }
    
    // Метод для читання чека з файлу
    public string ReadReceipt(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileLoadException("Файл не знайдено.");
        }

        return File.ReadAllText(filePath);
    }
}