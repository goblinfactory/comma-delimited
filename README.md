# comma-delimited

Cross platform .NET standard 1 native comma delimited data types for C# .NET core, .net framework, andriod, xamarin. 

![Goblinfactory.Delimited](https://github.com/goblinfactory/comma-delimited/workflows/Goblinfactory.Delimited/badge.svg)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT) 
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
public record Cat(CommaDelim Kittens);

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
CommaDelim cd = "12 3, aB  ,  6";
cd.ToString().Should().Be("12 3,aB,6");
cd[1] == "aB"
```

```csharp
public record Cat(CommaDelim Kittens);
var cat = new Cat("Mike, Bob,, Ginger");

cat.Kittens[3] == "Ginger";
```

## `CommaDelimUpper`

Delimited strings using comma (,). Whitespace is removed.  Values are converted to Invariant Uppercase.

```csharp
CommaDelimUpper cdu = "12 3, aB  ,  6";
cdu.ToString().Should().Be("12 3,AB,6");
cdu[1] == "AB"
```

```csharp
public record Cat(CommaDelimUpper Kittens);
var cat = new Cat("Mike, Bob,, Ginger");

cat.Kittens[3] == "GINGER";
```

## `CommaDelimLower`

Delimited strings using comma (,). Whitespace is removed.  Values are converted to Invariant lowercase.

```csharp
CommaDelimLower cdl = "12 3, aB  ,  6";
cdl.ToString().Should().Be("12 3,ab,6");
cdl[1] == "ab"
```

```csharp
public record Cat(CommaDelimUpper Kittens);
var cat = new Cat("Mike, Bob,, Ginger");

cat.Kittens[3] == "ginger";
```

## `PipeDelim`

Delimited strings using Pipe (|). Whitespace is removed. 
```csharp
PipeDelim pd = "12 3| aB  |  6";
pd.ToString().Should().Be("12 3|aB|6");
pd[1] == "aB"
```

```csharp
public record Cat(PipeDelim Kittens);
var cat = new Cat("Mike| Bob||Ginger");

cat.Kittens[1] == "Bob";
```

## `PipeDelimUpper`

Delimited strings using Pipe (|). Whitespace is removed. Values are converted to Invariant uppercase.

```csharp
PipeDelimUpper pdu = "12 3| aB  |  6";
pdu.ToString().Should().Be("12 3|AB|6");
pdu[1] == "AB"
```

```csharp
public record Cat(PipeDelimUpper Kittens);
var cat = new Cat("Mike| Bob||Ginger");
cat.Kittens[3] == "GINGER";
```

## `PipeDelimLower`

Delimited strings using Pipe (|). Whitespace is removed. Values are converted to Invariant lowercase.
```csharp
PipeDelimLower pdl = "12 3| aB  |  6";
pdl.ToString().Should().Be("12 3|ab|6");
pdl[1] == "ab"
```
```csharp
public record Cat(PipeDelimLower Kittens);
var cat = new Cat("Mike| Bob||Ginger");
cat.Kittens[3] == "ginger";
```

## C# 8 and lower

Typical pattern for assigning CommaDelim properties to string[] arrays works as follows;

```csharp
public class Cat
{
    public string[] Kittens;
    public Cat(CommaDelim kittens) {
        Kittens = kittens;
    }
}

var cat = new Cat("Mike, Bob,,Ginger");
cat.Kittens[3] == "ginger";

```

All the Delimited types work with all versions of C#. I've purely used C#9 record types above to simplify the documentation.




