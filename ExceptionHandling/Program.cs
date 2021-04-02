using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            int count = 0;
            try
            {
                while (count != 4)
                {
                    Console.WriteLine("Please enter a name");
                    names[count] = Console.ReadLine();
                    count++;
                }
            }
            catch (ArgumentNullException noInput)
            {
                Console.WriteLine("No Input Recieved: {0}", noInput);
            }
            catch (IndexOutOfRangeException wrongRange)
            {
                Console.WriteLine("Array out of range {1}", wrongRange);
            }
            finally
            {
                Console.WriteLine("User Names:");
                for(int i = 0; i < 7; i++)
                    {
                        Console.WriteLine(names[i]);
                    }
                /*foreach (string userinput in names)
                {
                    Console.WriteLine(userinput);
                }*/

            }
        }
    }
}
