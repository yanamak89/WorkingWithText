namespace Task2;

public class WebPageFetcher
{
    public async Task<string> FetchPageContentAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                return await client.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при отриманні сторінки: {ex.Message}");
                return null;
            }
        }
    }
}