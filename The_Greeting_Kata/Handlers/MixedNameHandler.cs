namespace The_Greeting_Kata.Handlers;

using System.Text.RegularExpressions;

public class MixedNameHandler : GreetingHandler
{
    private static readonly Regex EscapedCommaRegex = new Regex("\"([^\"]+)\"");

    public override string Handle(string[] names)
    {
        var allNames = new List<string>();

        foreach (var name in names)
        {
            if (name == null)
                continue;

            var matches = EscapedCommaRegex.Matches(name);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    allNames.Add(match.Groups[1].Value);
                }
            }
            else if (name.Contains(","))
            {
                allNames.AddRange(name.Split(',').Select(n => n.Trim()));
            }
            else
            {
                allNames.Add(name);
            }
        }

        var normalNames = allNames.Where(name => !string.IsNullOrEmpty(name) && !name.All(char.IsUpper)).ToList();
        var shoutedNames = allNames.Where(name => !string.IsNullOrEmpty(name) && name.All(char.IsUpper)).ToList();

        string normalGreeting = string.Empty;
        if (normalNames.Count > 0)
        {
            if (normalNames.Count == 1)
            {
                normalGreeting = $"Hello, {normalNames[0]}.";
            }
            else if (normalNames.Count == 2)
            {
                normalGreeting = $"Hello, {normalNames[0]} and {normalNames[1]}.";
            }
            else
            {
                normalGreeting = $"Hello, {string.Join(", ", normalNames.Take(normalNames.Count - 1))}, and {normalNames.Last()}.";
            }
        }

        string shoutedGreeting = string.Empty;
        if (shoutedNames.Count > 0)
        {
            shoutedGreeting = $"HELLO {string.Join(" AND ", shoutedNames)}!";
        }

        if (!string.IsNullOrEmpty(normalGreeting) && !string.IsNullOrEmpty(shoutedGreeting))
        {
            return $"{normalGreeting} {shoutedGreeting}";
        }

        return normalGreeting + shoutedGreeting;
    }
}


