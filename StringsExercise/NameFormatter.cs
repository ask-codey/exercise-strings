namespace StringsExercise;

public static class NameFormatter
{
    /*
     * You're given the parts of a name. Return the full name.
     * The first and last names always have a value. The middle
     * name and the suffix may be empty (""): leave them out,
     * with no extra spaces.
     *
     * FormatFullName("Glen", "", "Williamson", "") -> "Glen Williamson"
     * FormatFullName("Glen", "Carter", "Williamson", "") -> "Glen Carter Williamson"
     * FormatFullName("Glen", "", "Williamson", "Jr") -> "Glen Williamson, Jr"
     * FormatFullName("Glen", "Carter", "Williamson", "Jr") -> "Glen Carter Williamson, Jr"
     */
    public static string FormatFullName(string firstName, string middleName, string lastName, string suffix)
    {
        return "";
    }

    /*
     * Every new employee gets a username: their first and last
     * names in lowercase, with a period between them. If they
     * have a middle name, its first letter goes in the middle.
     * Anything after a comma (such as ", III") is left out.
     *
     * CreateUserName("Glen Williamson") -> "glen.williamson"
     * CreateUserName("Glen Carter Williamson") -> "glen.c.williamson"
     * CreateUserName("Glen Williamson, III") -> "glen.williamson"
     */
    public static string CreateUserName(string fullName)
    {
        return "";
    }

    /*
     * The company website lists people last name first.
     * A name here is a first name and a last name, sometimes
     * followed by a suffix: after a space ("III") or after a
     * comma (", PhD"). Keep everything after a comma as it is.
     *
     * ReformatName("Samuel Black") -> "Black, Samuel"
     * ReformatName("Lori Bell, PhD") -> "Bell, Lori, PhD"
     * ReformatName("Marcus Neuer III") -> "Neuer, Marcus, III"
     * ReformatName("Miguel Bennett Jr., MBA") -> "Bennett, Miguel, Jr., MBA"
     */
    public static string ReformatName(string fullName)
    {
        return "";
    }
}
