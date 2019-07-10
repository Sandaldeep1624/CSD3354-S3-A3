using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

class PlayingWithStack
{
    public void Run(Queue<String> tangerine)
    {
        Stack<String> name = new Stack<String>();
        foreach (var item in tangerine)
        }
            namespace.push(tangerine.Dequeue());
}
    


