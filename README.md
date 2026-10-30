# Exercise: Strings

Exercise code for the lesson **Exercise: Strings** in the C# Full-Stack Bootcamp on [ask-codey.com](https://www.ask-codey.com).

Fifteen string problems, in three classes in the `StringsExercise` project:

- `Markup.cs`: changing case, and building HTML and XML
- `NameFormatter.cs`: formatting, rearranging and turning names into usernames
- `WordPlay.cs`: bonus problems for when the first two files pass

Every method returns `""` (or another wrong answer) for now. The comment above each method says what it should return, with examples. Replace the `return` line with your own code.

## Run it

```bash
dotnet run --project StringsExercise
```

In Visual Studio, open `StringsExercise.slnx` and press **Ctrl+F5**. `Program.cs` calls a few of your methods, so you can try them out.

## Check your work

```bash
dotnet test
```

In Visual Studio, use **Test > Run All Tests**.

At first almost every test fails: that is expected. Each method you finish turns its tests green.

## Tips

- Use string interpolation: `$"<{elementName}>{content}</{elementName}>"`.
- `IndexOf` finds a character, `Substring` cuts, `Split` breaks text into words.
- A string never changes: keep the result of `ToLower()`, `Trim()` and the rest.

## Hand it in

When it works, push your solution to a public repo of your own on GitHub, then paste that repo's address into **Submit your exercise** on the lesson page at [ask-codey.com](https://www.ask-codey.com). That's what completes the lesson. The lesson page shows the Git commands, step by step.
