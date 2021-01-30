# comma-delimited

Cross platform .NET standard 1 native comma delimited data types for C# .NET core, .net framework, andriod, xamarin. 

![Goblinfactory.Delimited](https://github.com/goblinfactory/comma-delimited/workflows/Goblinfactory.Delimited/badge.svg?branch=master)

## Create method properties with real comma delimited data types.

The primary purpose of the library is to allow you to accept parameters using comma delimited or pipe delimited values and to assign those values immediately to a string[] in the constructor of your class.

```csharp
    public class CreateUser
    {
        public string[] Roles { get; }

        public CreateUser(string name, string password, PipeDelimUpper roles) {
            Name = name;
            Password = password;
            Roles = roles;  
        }
        // . . . 
    }

    var createFred = new CreateUser("Fred", "pa$$w0rd", "admin|guest|writer|reports");
    createFred.Roles[1] == "GUEST";

```

**The 6 main Comma Delimited data types are as follows

* `CommaDelim`
* `CommaDelimLower`
* `CommaDelimUpper`
* `PipeDelim`
* `PipeDelimLower`
* `PipeDelimUpper`

**Install**

```ruby
dotnet add package `Goblinfactory.Delimited`
```

**Example 1 - C#9 records**

In the example below, the default `CommaDelim` data type is being used.

```csharp
public record Cat(CommaDelim kittens);

var cat = new Cat("Mike, Bob, ,Ginger");

cat.Kittens.Should().BeEquivalentTo(new[] { 
    "Mike", 
    "Bob", 
    "",
    "Ginger"
});
```

Default behavior is

* Leading and trailing whitespace is trimmed.
* Empty items are converted to empty strings.
* Case is left as-is.
* No escaping of any delimiter characters are available. The assumption is that you have parsed (or encoded) the values yourself.
* Base class `DelimBase` is available if you need any alternative behavior.

**CommaDelim is enumerable**

```csharp
CommaDelim kittens  = "Mike, Bob, ,Ginger";
foreach(var cat in kittens) { 
    Console.WriteLine(cat);
}

... produces

Mike
Bob
[empty line]
Ginger
```
## `CommaDelim`

Delimited strings using comma (,). Whitespace is removed.

```csharp
public record Cat(CommaDelim kittens);
var cat = new Cat("Mike, Bob,, Ginger");

cat.Kittens[3] == "Ginger";
```

## `CommaDelimUpper`

Delimited strings using comma (,). Whitespace is removed.  Values are converted to Invariant Uppercase.

```csharp
public record Cat(CommaDelimUpper kittens);
var cat = new Cat("Mike, Bob,, Ginger");

cat.Kittens[3] == "GINGER";
```

## `CommaDelimLower`

Delimited strings using comma (,). Whitespace is removed.  Values are converted to Invariant lowercase.

```csharp
public record Cat(CommaDelimUpper kittens);
var cat = new Cat("Mike, Bob,, Ginger");

cat.Kittens[3] == "ginger";
```

## `PipeDelim`

Delimited strings using Pipe (|). Whitespace is removed. 
```csharp
public record Cat(PipeDelim kittens);
var cat = new Cat("Mike| Bob||Ginger");

cat.Kittens[1] == "Bob";
```

## `PipeDelimUpper`

Delimited strings using Pipe (|). Whitespace is removed. Values are converted to Invariant uppercase.
```csharp
public record Cat(PipeDelimUpper kittens);
var cat = new Cat("Mike| Bob||Ginger");
cat.Kittens[3] == "GINGER";
```

## `PipeDelimLower`

Delimited strings using Pipe (|). Whitespace is removed. Values are converted to Invariant lowercase.
```csharp
public record Cat(PipeDelimLower kittens);
var cat = new Cat("Mike| Bob||Ginger");
cat.Kittens[3] == "ginger";
```





