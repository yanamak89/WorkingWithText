using System.Text.RegularExpressions;

namespace Task3;

public class Deshifrator
{
    // Список прийменників, які ми будемо замінювати
    private List<string> prepositions = new List<string>()
    {
        "в", "на", "за", "під", "над", "про", "до", "від", "із",
        "по", "через", "біля", "окрім", "поза", "між", "перед"
    };
    
    // Метод для заміни прийменників на "ГАВ!"
    public string DecodeText(string text)
    {
        foreach (var preposition in prepositions)
        {
            // Використання регулярного виразу для заміни прийменників
            string pattern = $@"\b{preposition}\b";
            text = Regex.Replace(text, pattern, "ГАВ!", RegexOptions.IgnoreCase);
        }
        return text;
    }

    
}