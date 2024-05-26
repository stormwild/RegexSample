using System.Text.RegularExpressions;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("------ Regex Sample -----");

string[] inputs = { "Version=\"1.3.0\"", "Version=\"2.2.0\"", "Version=\"2.4.1\"" };

string pattern = @"Version=""\d+(\.\d+)+""";

foreach (string input in inputs)
{
    Match match = Regex.Match(input, pattern);
    if (match.Success)
    {
        Console.WriteLine($"Matched: {match.Value}");
    }
    else
    {
        Console.WriteLine("No match");
    }
}

Console.WriteLine("------ Pattern -----");
Console.WriteLine(pattern);