# Reader
[*__BACKLINK__*](../README.md)

The Reader class in [Util/Reader](../Util/Reader.cs) is a helper class for reading input from the console.

The Reader class uses an advanced concept called generics.

> __*Further explanation will follow*__

```cs
//The Reader class contains methods simalar to the following:
int input = TryNumericRead<Int>("something: ");
// it is basicly the same as:
Console.WriteLine("something: ");
String input = Console.ReadLine();
int number = int.Parse(input);
```

## LINKS
[wiki](https://en.wikipedia.org/wiki/Generic_programming)

[c# documentation](https://learn.microsoft.com/en-us/dotnet/standard/generics/)