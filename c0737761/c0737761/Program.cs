using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace c0737761
  
{
    class Program
    {
        static void Main(string[] args)
        {

           

            int counter = 0;
            string line;


            System.IO.StreamReader file =
                new System.IO.StreamReader(@"U:\Users\737761\CSD3354-S3-A3\c0737761\c0737761\names.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}



class stack
{ 
static void Main(string[] args)
{

        
        Stack myStack = new Stack();
        myStack.Push("Hello");
        myStack.Push("World");
        myStack.Push("!");

      
        Console.WriteLine("myStack");
        Console.WriteLine("\tCount:    {0}", myStack.Count);
        Console.Write("\tValues:");
    Console.Write(myStack);
    }

    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }

}


