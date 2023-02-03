# Encapsulation

[Box.cs](https://github.com/pratyakshm/Cs_MasterClass/blob/main/OOP/Encapsulation/Box.cs) ([Permalink](https://github.com/pratyakshm/Cs_MasterClass/blob/3f6becd964e690552216fe56c89ce067d4827e58/OOP/Encapsulation/Box.cs))

Encapsulation is the process of ensuring that the internal representation of an object is hidden from the outside world and is not accessible.

This is achieved by declaring all the variables in the class as private and writing public methods in the class to set and get the values of variables.

```csharp
public void SetLength(int length)
{
    this.length = length;
}

public int GetLength()
{
    return length;
}
```

### Can also be written as...

```csharp
public int Length
{
    get { }
    set { }
}
```

or

```csharp
// type `prop` and press Tab key twice
public int Width { get; set; }
```

## Why Encapsulation?

Encapsulation is used to hide the values or state of a structured data object inside a class, preventing unauthorized parties' direct access to them.
