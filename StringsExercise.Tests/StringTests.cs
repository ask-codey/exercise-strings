using StringsExercise;

namespace StringsExercise.Tests;

// Each test calls one of your methods and checks what it returns.
// You don't need to change this file.

[TestClass]
public class MarkupTests
{
    [TestMethod]
    [DataRow("Fancy", false, "fancy")]
    [DataRow("chocolate", true, "CHOCOLATE")]
    [DataRow("PARTY", false, "party")]
    [DataRow("PARTY", true, "PARTY")]
    [DataRow("MiXeDwOrD", false, "mixedword")]
    public void ChangeCase(string word, bool toUpperCase, string expected)
    {
        Assert.AreEqual(expected, Markup.ChangeCase(word, toUpperCase), $"\"{word}\" (uppercase: {toUpperCase}) becomes \"{expected}\".");
    }

    [TestMethod]
    [DataRow("This is a paragraph", "p", "<p>This is a paragraph</p>")]
    [DataRow("Bold text", "strong", "<strong>Bold text</strong>")]
    [DataRow("Italic", "em", "<em>Italic</em>")]
    public void CreateHtml(string content, string elementName, string expected)
    {
        Assert.AreEqual(expected, Markup.CreateHtml(content, elementName));
    }

    [TestMethod]
    [DataRow("This is a paragraph", "p", "<p>This is a paragraph</p>")]
    [DataRow("", "p", "<p />")]
    [DataRow("", "hr", "<hr />")]
    public void MoreHtml(string content, string elementName, string expected)
    {
        Assert.AreEqual(expected, Markup.MoreHtml(content, elementName));
    }

    [TestMethod]
    [DataRow(1, "Belinda Carter")]
    [DataRow(15, "Howard Jones")]
    public void CreateXml(int id, string name)
    {
        string expected = $"<customer><id>{id}</id><name>{name}</name></customer>";

        Assert.AreEqual(expected, Markup.CreateXml(id, name));
    }

    [TestMethod]
    [DataRow(1, "Belinda Carter")]
    [DataRow(31, "Grant Ward")]
    public void FormattedXml(int id, string name)
    {
        string expected = "<customer>\n" +
                          $"  <id>{id}</id>\n" +
                          $"  <name>{name}</name>\n" +
                          "</customer>";

        Assert.AreEqual(expected, Markup.FormattedXml(id, name), "Each element is on its own line, the inner ones indented by 2 spaces.");
    }
}

[TestClass]
public class NameFormatterTests
{
    [TestMethod]
    [DataRow("Glen", "", "Williamson", "", "Glen Williamson")]
    [DataRow("Glen", "Carter", "Williamson", "", "Glen Carter Williamson")]
    [DataRow("Glen", "", "Williamson", "Jr", "Glen Williamson, Jr")]
    [DataRow("Glen", "Carter", "Williamson", "Jr", "Glen Carter Williamson, Jr")]
    public void FormatFullName(string first, string middle, string last, string suffix, string expected)
    {
        Assert.AreEqual(expected, NameFormatter.FormatFullName(first, middle, last, suffix));
    }

    [TestMethod]
    [DataRow("Glen Williamson", "glen.williamson")]
    [DataRow("Glen Carter Williamson", "glen.c.williamson")]
    [DataRow("Glen Williamson, III", "glen.williamson")]
    public void CreateUserName(string fullName, string expected)
    {
        Assert.AreEqual(expected, NameFormatter.CreateUserName(fullName));
    }

    [TestMethod]
    [DataRow("Samuel Black", "Black, Samuel")]
    [DataRow("Lori Bell, PhD", "Bell, Lori, PhD")]
    [DataRow("Marcus Neuer III", "Neuer, Marcus, III")]
    [DataRow("Miguel Bennett Jr., MBA", "Bennett, Miguel, Jr., MBA")]
    public void ReformatName(string fullName, string expected)
    {
        Assert.AreEqual(expected, NameFormatter.ReformatName(fullName));
    }
}

[TestClass]
public class WordPlayTests
{
    [TestMethod]
    [DataRow("Glen Carter Williamson", "GCW")]
    [DataRow("ohio state", "OS")]
    [DataRow("Georgia", "G")]
    public void Initials(string name, string expected)
    {
        Assert.AreEqual(expected, WordPlay.Initials(name));
    }

    [TestMethod]
    [DataRow("season.scores.final.csv", "csv")]
    [DataRow("photo.png", "png")]
    [DataRow("README", "")]
    public void FileExtension(string fileName, string expected)
    {
        Assert.AreEqual(expected, WordPlay.FileExtension(fileName));
    }

    [TestMethod]
    [DataRow("4111111111111111", "************1111")]
    [DataRow("12345678", "****5678")]
    [DataRow("1234", "1234")]
    public void MaskCardNumber(string cardNumber, string expected)
    {
        Assert.AreEqual(expected, WordPlay.MaskCardNumber(cardNumber));
    }

    [TestMethod]
    [DataRow("Georgia", 4)]
    [DataRow("Ohio State", 5)]
    [DataRow("rhythm", 0)]
    public void CountVowels(string text, int expected)
    {
        Assert.AreEqual(expected, WordPlay.CountVowels(text), $"\"{text}\" has {expected} vowels.");
    }

    [TestMethod]
    [DataRow("racecar", true)]
    [DataRow("Level", true)]
    [DataRow("Georgia", false)]
    public void IsPalindrome(string word, bool expected)
    {
        Assert.AreEqual(expected, WordPlay.IsPalindrome(word));
    }

    [TestMethod]
    [DataRow("That was a bad call", "bad", "That was a *** call")]
    [DataRow("rain rain go away", "rain", "**** **** go away")]
    [DataRow("sunny day", "rain", "sunny day")]
    public void Censor(string sentence, string word, string expected)
    {
        Assert.AreEqual(expected, WordPlay.Censor(sentence, word));
    }

    [TestMethod]
    [DataRow("ohio state buckeyes", "Ohio State Buckeyes")]
    [DataRow("THE BIG GAME", "The Big Game")]
    public void TitleCase(string text, string expected)
    {
        Assert.AreEqual(expected, WordPlay.TitleCase(text));
    }
}
