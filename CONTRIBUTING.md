# Contirbuting

### Introduction
First of all, big thanks for taking your time to contributing =) 

### Important for all Contributors
When contributing to this repository, please first discuss the change you wish to make via issues or any method with the owners of this repository before making a change.

### How to be sure that my contribution will be accepted 100%
* Write your code simple and readable.
* Abide by .NET Microsoft advices how to write code better.
* Abide by "SOLID" principles.
* Abide by "OOP".
* Abide by "code style" in project.
* Clean all not used usings.
* Use desing patterns if is it requires.
* Surely for all interfaces you did write XMLDoc documentation (`/// \<summary\>`) or (`//`).
* Avoid to many comments. (do not add comments to all classes or line of your code you did)
* Surely avoid classes with name "Manager" or "Controller" which controll all your code.
* All commits you did describe it properly. ("Added class", "Fixed bug" not a "new commit is here! =)")

### Bad contribution example
```cs
// my formatter class
public class UIElementsManagerControllerProcessor
{
    // format string and try get magic
    public static bool trygetmagicfromtext(string value)
    {
        // checking if value equals to magic!
        if (value == "magic")
        {
            // returning result!
            return value != null;
        }

        // code end! =)
        return false;
        //bye!
    }
    //bye ! 0:
}
```

### Good contribution example
```cs
public class SimpleStringFormatter : IFormatter
{
    private const string MagicText = "magic";



    public bool TryFormat(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentNullException(nameof(value));

        if (value == MagicText)
        {
            return true;
        }

        return false;
    }
}

/// <summary>
/// Formatter of strings.
/// </summary>
public interface IFormatter
{
    /// <summary>
    /// Formatting method.
    /// </summary>
    /// <param name="value">string what you want to format</param>
    /// <returns>the result of formatting</returns>
    bool TryFormat(string value);
}
```

### Testing
* If after your changes project is building without errors and you followed the [rules](https://github.com/sunnamed434/UIElementsUnturned/blob/main/CONTRIBUTING.md#how-to-be-sure-that-my-contribution-will-be-accepted-100) how to contribute properly.
* Pull your request, and if your pull request was successful passed our CI workflow you are welcome!
