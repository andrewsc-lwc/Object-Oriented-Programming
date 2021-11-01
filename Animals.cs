using System;

public class Animals
{
	private int size;
	private string colour;
	private int age;
	private int legs;


    public Animals(int size, string colour, int age, int legs)
    {
        Size = size;
        Colour = colour;
        Age = age;
        Legs = legs;
    }

    public int Size { get => size; set => size = value; }
    public string Colour { get => colour; set => colour = value; }
    public int Age { get => age; set => age = value; }
    public int Legs { get => legs; set => legs = value; }
}

public class Cat : Animals
{
    private string breed;
    private string owner;

    public Cat(int size, string colour, int age, int legs, string breed, string owner) : base(size, colour, age, legs)
    {
        Breed = breed;
        Owner = owner;
    }

    public string Breed { get => breed; set => breed = value; }
    public string Owner { get => owner; set => owner = value; }
}