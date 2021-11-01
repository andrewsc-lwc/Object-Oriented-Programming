using System;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new (10, "Blue", 21, 5);
            Console.WriteLine(cat.Size);
            Cat newCat = new Cat(24, "Green", 3, 4, "Tabby", "Mr Andrews");
            Console.WriteLine(newCat.Owner);
        }
    }
}
