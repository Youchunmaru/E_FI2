# OOP
[*__BACKLINK__*](../README.md)

The idea behind OOP(Object Oriented Programming) is the abstraction of a programm into smaller parts.
The content of those parts should have something in commen. This should provide better understanding of the code. It also provides reuseability.

For exapmle the logic of a dog:

```cs

public static void Main(String[] args){
    Dog lessie = new Dog("Lassie", 12);
    lassie.Bark();
    lassei.Fetch(100);
    lassie.Birthday();
    Console.WriteLine(lassie.GetAge());
    Dog scoobyDoo = new Dog("Scooby Doo", 17);
    scoobyDoo.Bark();
}

/*output:
Woof!!
*Lassie runs 100m in the direction of the stick*
*Lassie runs back to you with the stick*
*Lassie waits for you to throw the stick again*
13
Woof!!
*/
class Dog {
    private String name;
    private int age;

    public Dog(String name, int age){
        this.name = name;
        this.age = age;
    }

    public void Bark(){
        Console.WriteLine("Woof!!");
    }

    public void Fetch(int distance){
        Console.WriteLine($"*{name} runs {distance}m in the direction of the stick*");
        Console.WriteLine($"*{name} runs back to you with the stick*");
        Console.WriteLine($"*{name} waits for you to throw the stick again*");
    }

    public void Birthday(){
        age++;
    }

    public int GetAge(){
        return age;
    }
}
```
## LINKS
[wiki](https://en.wikipedia.org/wiki/Object-oriented_programming)

[c# documentation](https://learn.microsoft.com/en-us/shows/programming-in-c-jump-start/programming-in-c-01-oop-managed-languages-c)