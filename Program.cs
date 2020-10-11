using DesignPatterns.Builder;
using System;

namespace DesignPatterns
{
    class Program
    {
        public enum Color
        {
            Red, Green, Blue
        }

        public enum Size
        {
            Small, Medium, Large, Huge
        }

        public class Product
        {
            public string Name;
            public Color Color;
            public Size Size;

            public Product()
            {
                    
            }
        }
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person");
            cb.AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb.ToString());
        }
    }
}
