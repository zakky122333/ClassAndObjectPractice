
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating the object
            Phone phone = new Phone("Gold", "iPhone", 22);

            Console.WriteLine(phone.colour);
            Console.WriteLine(phone.HasEnoughStorage()); // calling the method
            Console.ReadLine();
        }
    }
}
