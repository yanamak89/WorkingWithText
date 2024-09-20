using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace Task2;

public class ContentParser
{
    public string[] ExtractLinks(string htmlContent)
    {
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(htmlContent);

        var linkNodes = doc.DocumentNode.SelectNodes("//a[@href]");
        var links = new List<string>();

        if (linkNodes != null)
        {
            foreach (var node in linkNodes)
            {
                links.Add(node.Attributes["href"].Value);                
            }
        }

        return links.ToArray();
    }

    public string[] ExtractEmails(string htmlContent)
    {
        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
        MatchCollection emailMatches = Regex.Matches(htmlContent, emailPattern);

        var emails = new List<string>();
        foreach (Match match in emailMatches)
        {
            emails.Add(match.Value);
        }

        return emails.ToArray();
    }

    public string[] ExtractPhoneNumbers(string htmlContent)
    {
        string phonePattern = @"\+?\d{1,4}[\s.-]?\(?\d{1,3}\)?[\s.-]?\d{1,4}[\s.-]?\d{1,4}[\s.-]?\d{1,9}";
        MatchCollection phoneMatches = Regex.Matches(htmlContent, phonePattern);

        var phones = new List<string>();
        foreach (Match match in phoneMatches)
        {
            phones.Add(match.Value);
        }

        return phones.ToArray();
    }
}