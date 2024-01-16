# Conditional Operator
[*__BACKLINK__*](../README.md)

Also sometimes call ternary operator.

The conditional operator consits of to symbols:

`?` and `:`

there are applied like this:

`condition ? then : else`

- **condition:** is a boolean expression therfore resulting in `true` or `false`
- **then:** is evaluated if the condition is `true`
- **else:** is evaluated if the condition is `false`

So it is basicaly like an if expression but shorter:

```cs
String ternary = condition ? "then" : "else"
//same as
String ternary;
if(condition){
    ternary = "then";
}else{
    ternary = "else";
}
```

```cs
int a = 1;
int b = 2;
String ternary = a > b ? "a > b" : "b >= a";
Console.WriteLine(ternary);//output: b >= a
```
**Note that it doesnt have to result in assigning a variable,
you can also use it to invoke methods**
## LINKS
[wiki](https://en.wikipedia.org/wiki/Conditional_operator)

[c# dokumentation](https://learn.microsoft.com/en-us/cpp/cpp/conditional-operator-q?view=msvc-170)