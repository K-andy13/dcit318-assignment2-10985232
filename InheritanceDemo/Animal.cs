using System;
class Animal
{

    public virtual void MakeSound() { Console.WriteLine("Some generic sound."); }

    class Dog : Animal
    {
        public override void MakeSound() { Console.WriteLine("Bark"); }
    }
    class Cat : Animal
    {
        public override void MakeSound() { Console.WriteLine("Meow"); }
    }

    public static void Main()
    {
        Animal animal = new(); //Works same as new Animal()
        Console.Write("Animal: ");
        animal.MakeSound();


        Dog dog = new();
        Console.Write("Dog: ");
        dog.MakeSound();

        Cat cat = new();
        Console.Write("Cat: ");

        cat.MakeSound();

    }
}