# Functions
[*__BACKLINK__*](../README.md)

Or sometimes called methods.

Functions are a fundamental building part of programming languages. They are used to compartmentalize programms into smaller reusable parts.

```cs
//a function called Main
//the Main function is the entry point for all programms
public static void Main(String[] args){
    //logic to run when the programm is started
    Method();
    Plus(1,2);
    Console.WriteLine(Minus(1,2));
}

public static void Method(){
    Console.WriteLine("Inside Method");
}
//you can give a function parameters to use inside
public static void Plus(int a, int b){
    Console.WriteLine(a + b);
}
//you can also assign a return type to a function instead of void
public static int Minus(int a, int b){
    return a - b;
}
/*output:
Inside Method
3
-1
*/
```
## LINKS
[wiki](https://en.wikipedia.org/wiki/Function_(computer_programming))

[c# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions)