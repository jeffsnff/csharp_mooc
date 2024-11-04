# Notes on CSharp

### Code Snippets to remeber

```
// Formatting Code to CSharp standard
SHIFT + OPTION + F ( MAC )
```

In most programming languages, string is of reference type, and integer, boolean and double are value types.

To compare a string in C#:

```clike
// Comparing string with equal to operator
string a = "word";
string b = "word";
Console.WriteLine(a==b);
// Would evaluate to True
```

```C-like
// Comparing string with equals-method
string a = "dog";
string b = "dog";
Console.WriteLine(a.Equals(b));
// Would evvaluate to True
```

## While Loops

break - Breaks the loop

continue - will restart from the beginning of the loop

