using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] num = new int[3];
                num[3] = 23;
            }
            catch(System.IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("That is the final code.");
            }
        }
    }
}
