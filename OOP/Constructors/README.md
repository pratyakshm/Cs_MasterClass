# Constructors

[Human.cs](https://github.com/pratyakshm/Cs_MasterClass/blob/main/OOP/Constructors/Human.cs) ([Permalink](https://github.com/pratyakshm/Cs_MasterClass/blob/32e33f565aaa4299ab9e67207e8119b414d05d93/OOP/Constructors/Human.cs))

## Constructors

These are ✨ special methods ✨ that always run whenever an object is created. It allows us to run a bunch of commands when an object is created. Typically, it's used to assign data to variables during object creation.

A constructor tags along with the `this` keyword. It's used to refer to the current instance of the class.

## Parameterized Constructor

```csharp
public Human(string firstName, string lastName, float age, string eyeColor)
{
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.eyeColor = eyeColor;
}
```

## Overloading Constructors

You can have mulitple constructors (a.k.a those special methods) in a class. This is to account for different scenarios. For example, you can have a constructor that takes three arguments, another that can take four, etc.

```csharp
public Human(string firstName, string lastName, float age, string eyeColor)
{
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.eyeColor = eyeColor;
}

public Human()
{
    Console.WriteLine("Default constructor called, object created.");
}
```

## Default Constructor

A default constructor is a constructor that takes no arguments. It's used when you want to create an object with no data.

```csharp
public Human()
{
    Console.WriteLine("Default constructor called, object created.");
}
```

## Calling Constructors

You can call a constructor by using the `new` keyword.

```csharp
Human human = new Human("John", "Doe", 25, "blue");
```

## Calling Default Constructor

You can call a default constructor by using the `new` keyword without any arguments.

```csharp

Human human = new Human();
```
