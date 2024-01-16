# Kast - cSharp

You will find here the solutions for all coding tasks. The folders are named after the sections in moodle.
There can be an alternative solution for every task. The alternative solution isn't neccesarely better, faster or more complex.
It is only there to provide more insight into c#.

- [Running the task sheets](#running-the-task-sheets)
- [What is ...?](#what-is)
    - [Functions](#functions)
    - [Reader](#reader)
    - [Lambdas](#lambdas)
    - [Conditional Operator](#conditional-operator)
    - [OOP](#object-oriented-programming)
- [Task List](#task-list)
    - [Data Types](#datatypes)
    - [Branching](#branching)
    - [Loops](#loops)
    - [Arrays](#arrays)

## Running the task sheets
```cs
<FolderName>.<ClassName>.Run();
// e.g.:
DataTypes.Task4ABJKL.RunAll();
// for the normal solution:
DataTypes.Task4ABJKL.Run();
// for the alternative solution
DataTypes.Task4ABJKL.Run_();
```

```shell
# to run the programm make sure you have .NET 7.0 installed
# switch to project dir
cd Kast/cSharp
# run with
dotnet run
```
## What is ...?
__**CLICK ON HEADER FOR MORE INFORMATION**__
### [Functions](Concepts/Functions.md)
```cs
public static void Run(){
    Console.WriteLine("Hi");
    //...
}
```
### [Reader](Concepts/Reader.md)
```cs
int input = TryNumericReader<int>("something: ");
```
### [Lambdas](Concepts/Lambdas.md)
```cs
(x) => x * 2
```
### [Conditional Operator](Concepts/ConditionalOperator.md)
```cs
String biggest = a > b ? a : b;
```
### [Object Oriented Programming](Concepts/OOP.md)
```cs
class Box{
    private final int x,y,z;
    private bool open = false;
    public Box(int x, int y, int z){
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public void open(){
        open = true;
    }
    public void close(){
        open = false;
    }
}
```
## Task List

### DataTypes

[DataTypes - 4abjkl](DataTypes/Task4ABJKL.cs)

[DataTypes - Extra](DataTypes/KartonProjekt.cs)

### Branching

[Branching - 5abcde](Branching/TaskFiveABCDE.cs)

[Branching - Taxes](Branching/Taxes.cs)

[Branching - switchCase](Branching/SwitchCase.cs)

[Branching - 5fgh](Branching/TaskFiveFGH.cs)

[Branching - MultiBranching](Branching/MultiBranching.cs)

### Loops

[Loops - 6ab](Loops/Task6AB.cs)

[Loops - 6cdef](Loops/Task6CDEF.cs)

[Loops - 6g](Loops/Task6G.cs)

[Loops - 6h](Loops/Task6H.cs)

[Loops - 6i](Loops/Task6I.cs)

[Loops - Extra](Loops/Extra.cs)

### Arrays

[Arrays - 1a](Arrays/Task1A.cs)

[Arrays - 1a](Arrays/Task1B.cs)

[Arrays - 1a](Arrays/Task1C.cs)

[Arrays - 1a](Arrays/Task1D.cs)

[Arrays - 1a](Arrays/Task1E.cs)

[Arrays - 1a](Arrays/Task1F.cs)

[Arrays - 1a](Arrays/Task1G.cs)

[Arrays - 1a](Arrays/Task1H.cs)
