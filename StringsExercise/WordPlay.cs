namespace StringsExercise;

// Bonus problems: try these when the other two files pass.
public static class WordPlay
{
    /*
     * Return the first letter of each word, in uppercase.
     *
     * Initials("Glen Carter Williamson") -> "GCW"
     * Initials("ohio state") -> "OS"
     * Initials("Georgia") -> "G"
     */
    public static string Initials(string name)
    {
        return "";
    }

    /*
     * Return the part of a file name after its last period,
     * or "" if it has no period.
     *
     * FileExtension("season.scores.final.csv") -> "csv"
     * FileExtension("photo.png") -> "png"
     * FileExtension("README") -> ""
     */
    public static string FileExtension(string fileName)
    {
        return "?";
    }

    /*
     * Hide all but the last 4 digits of a card number with *.
     * The number has at least 4 digits.
     *
     * MaskCardNumber("4111111111111111") -> "************1111"
     * MaskCardNumber("12345678") -> "****5678"
     * MaskCardNumber("1234") -> "1234"
     *
     * (Hint: "1111".PadLeft(8, '*') is "****1111".)
     */
    public static string MaskCardNumber(string cardNumber)
    {
        return "";
    }

    /*
     * Count the vowels (a, e, i, o, u), capital or not.
     *
     * CountVowels("Georgia") -> 4
     * CountVowels("Ohio State") -> 5
     * CountVowels("rhythm") -> 0
     */
    public static int CountVowels(string text)
    {
        return -1;
    }

    /*
     * A palindrome reads the same forward and backward.
     * Return true if the word is one, capital letters or not.
     *
     * IsPalindrome("racecar") -> true
     * IsPalindrome("Level") -> true
     * IsPalindrome("Georgia") -> false
     */
    public static bool IsPalindrome(string word)
    {
        return word == "";
    }

    /*
     * Replace every copy of a word with stars, one per letter.
     *
     * Censor("That was a bad call", "bad") -> "That was a *** call"
     * Censor("rain rain go away", "rain") -> "**** **** go away"
     * Censor("sunny day", "rain") -> "sunny day"
     */
    public static string Censor(string sentence, string word)
    {
        return "";
    }

    /*
     * Capitalize the first letter of every word, and make the
     * rest of each word lowercase. Words are separated by spaces.
     *
     * TitleCase("ohio state buckeyes") -> "Ohio State Buckeyes"
     * TitleCase("THE BIG GAME") -> "The Big Game"
     */
    public static string TitleCase(string text)
    {
        return "";
    }
}
