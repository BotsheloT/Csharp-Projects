using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of Array with names
            string[] names = {"Botshelo", "Masego", "Boitumelo", "Tshepiso"};
            //display with foreach statement
            Console.WriteLine("The Tlhabanyane Family Consists of\t>>");
            foreach (string stuff in names)
            {
                Console.WriteLine(stuff);
            }
        }
    }
}
