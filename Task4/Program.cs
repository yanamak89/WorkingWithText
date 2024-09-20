/*
 * Завдання 4   
   Створіть текстовий файл-чек на кшталт «Найменування товару –
    0.00(ціна)грн.» з певною кількістю найменувань товарів та 
    датою здійснення покупки. Виведіть на екран інформацію з 
    чека у форматі поточної локалі користувача та у форматі 
    локалі en-US.
 */


using System.Globalization;
using Task4;

class Program
{
    public static void Main(string[] args)
    {
        // Створюємо екземпляр класу ReceiptGenerator
        DisplayRecept displayRecept = new DisplayRecept();
        
        // Шлях до файлу-чека
        string filePath = "receipt.txt";
        
        
        // Створюємо файл-чек та читаємо чек з файлу
        ReceiptGenerator generator = new ReceiptGenerator();
        string receipt = generator.ReadReceipt(filePath);
        
        
        // Виведення чека в поточній локалі
        Console.WriteLine("Чек у поточній локалі: ");
        Console.WriteLine(receipt);
        
        // Виведення чека у форматі локалі en-US
        CultureInfo usCulture = new CultureInfo("en-US");
        Console.WriteLine("\nЧек у форматі локалі en-US: ");
        displayRecept.DisplayReceptCulture(receipt, usCulture);
    }
}