using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (quit != true)
            {
                Showmenu();
                switch (Console.ReadLine().Trim().ToLower())
                {
                    case "p":
                        {
                            Products product = new Products(13.00m, "knife");
                            Console.WriteLine(product);
                            break;
                        }
                    case "q":
                        {
                            quit = true;
                            break;
                        }

                }
            }
           
        }

        private static void Showmenu()
        {
           Console.WriteLine("Press Q to Quit");
           Console.WriteLine("Press P to see Products");
           
        }
    }
}
