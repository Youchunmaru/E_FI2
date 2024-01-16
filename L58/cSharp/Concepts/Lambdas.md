# Lambdas
[*__BACKLINK__*](../README.md)

Lambdas are a short way to write simple functions.
Another practical part of lambdas is that you can assign them to a variable and use them there as needed.

```cs
//lambda to calculate the radius
Func<int,double> lambda = (x) -> 2 * x * 3.1415;
Console.WriteLine("radius: " + lambda(1));//output: 6.1830
Func <double> pi = () -> {
    double pi = 3.1415;
    return pi;
    };//returns pi

//example using a normal function:
Console.WriteLine("radius: " + Radius(1));

public static double Radius(int r){
    return 2 * r * 3.1415;
}
```

## LINKS
[wiki](https://en.wikipedia.org/wiki/Anonymous_function)

[c# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions)