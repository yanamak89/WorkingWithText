using System.Globalization;

namespace Task4;

public class DisplayRecept
{

    // Метод для форматування і відображення чека у різних локалях
    public void DisplayReceptCulture(string receipt, CultureInfo usCulture)
    {
        // Виведення чека з урахуванням локалі
        string[] lines = receipt.Split('\n');
        foreach (string line in lines)
        {
            if (line.StartsWith("Дата покупки:"))
            {
                // Витягуємо дату з рядка
                string datePart = line.Replace("Дата покупки:", "").Trim();
                if (DateTime.TryParse(datePart, out DateTime purchaseDate))
                {
                    // Форматування дати відповідно до локалі
                    string formattedDate = purchaseDate.ToString(usCulture);
                    Console.WriteLine($"Дата покупки: {formattedDate}");
                }
                else
                {
                    // Якщо не вдалося розпарсити дату, виводимо рядок як є
                    Console.WriteLine(line);
                }
            }
            else if (line.Contains("грн."))
            {
                // Знаходимо товар і ціну
                int priceIndex = line.IndexOf('–');
                if (priceIndex != -1 && line.Contains("грн."))
                {
                    // Знаходимо товар і ціну
                    string item = line.Substring(0, priceIndex).Trim();
                    string priceString = line.Substring(priceIndex + 1).Replace("грн.", "").Trim();

                    if (decimal.TryParse(priceString, out decimal price))
                    {
                        // Форматування ціни відповідно до локалі без зміни валюти
                        string formattedPrice = price.ToString("N", usCulture) + "грн.";
                        Console.WriteLine($"{item} - {formattedPrice}");
                    }
                    else
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}