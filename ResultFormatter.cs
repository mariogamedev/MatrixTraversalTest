public static class ResultFormatter
{
    public static string RemoveTrailingCharacters(string input)
    {
        // Check if the input is not empty
        if (string.IsNullOrEmpty(input))
            return input;

        // Remove trailing comma and space if present
        return input.TrimEnd(',', ' ');
    } 
} 