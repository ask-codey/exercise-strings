namespace StringsExercise;

public static class Markup
{
    /*
     * Convert a word to all uppercase or all lowercase letters.
     * toUpperCase says which.
     *
     * ChangeCase("Fancy", false) -> "fancy"
     * ChangeCase("chocolate", true) -> "CHOCOLATE"
     * ChangeCase("PARTY", false) -> "party"
     * ChangeCase("PARTY", true) -> "PARTY"
     */
    public static string ChangeCase(string word, bool toUpperCase)
    {
        return "";
    }

    /*
     * Web pages are written in HTML, which is made of elements
     * (also called tags) like this:
     *
     * <p>your content here</p>
     *
     * The element's name, here p for paragraph, goes in an
     * opening tag <p> and a closing tag </p>, with the content
     * between them.
     *
     * Return the HTML for the content and element name given.
     *
     * CreateHtml("This is a paragraph", "p") -> "<p>This is a paragraph</p>"
     * CreateHtml("Bold text", "strong") -> "<strong>Bold text</strong>"
     */
    public static string CreateHtml(string content, string elementName)
    {
        return "";
    }

    /*
     * In XML, an element with no content can close itself: <p />
     * (A real web page writes <p></p>; this exercise uses the XML way.)
     *
     * Return a self-closing element when the content is empty,
     * and the usual HTML otherwise.
     *
     * MoreHtml("This is a paragraph", "p") -> "<p>This is a paragraph</p>"
     * MoreHtml("", "p") -> "<p />"
     */
    public static string MoreHtml(string content, string elementName)
    {
        return "";
    }

    /*
     * XML looks like HTML, but you choose the element names
     * yourself, to describe your data:
     *
     * <customer><id>1</id><name>Belinda Carter</name></customer>
     *
     * Return a customer's XML, on one line, like the example.
     *
     * CreateXml(1, "Belinda Carter") -> "<customer><id>1</id><name>Belinda Carter</name></customer>"
     */
    public static string CreateXml(int id, string name)
    {
        return "";
    }

    /*
     * XML on one line is hard to read. Return it with each
     * element on its own line (use \n for a new line), and
     * the inner elements indented by 2 spaces:
     *
     * <customer>
     *   <id>1</id>
     *   <name>Belinda Carter</name>
     * </customer>
     *
     * There's no new line after </customer>.
     */
    public static string FormattedXml(int id, string name)
    {
        return "";
    }
}
