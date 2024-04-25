using System;
namespace Overriding;
class Animal{
    public virtual void Eat(){
        Console.WriteLine("Animals Eat Food");
    }
}


class Dog:Animal{
    public override void Eat(){
        Console.WriteLine("Dogs Eat Food");
        base.Eat();


    }
}
class Pomerian:Dog{
    public override void Eat()
    {
       Console.WriteLine("Pomerians Eat Food");
       base.Eat();
 
    }

}
class Program{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Pomerian pomerian = new  Pomerian();
        animal.Eat();
        dog.Eat();
        pomerian.Eat();
        
    }
}