using System.Text.RegularExpressions;

internal class Task6
{
    static void Main()
    {
        string target = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = $@"([A-Z][A-Z,a-z]*(\s?\w*|[,]|[-])*)*(\b({target})\b)((\s?\w*|[,]|[-])*[A-Z,a-z]*[!,\.,?])";

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        
        if (matches.Count > 0)
        {
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else { Console.WriteLine("No matches found"); }
    }
}