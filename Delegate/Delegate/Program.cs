using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    // Step 1: define a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    internal class Program
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Program p =  new Program();

            // Step 2: instantiating the delegate
            // creating instance of delegate
            AddDelegate ad = new AddDelegate(p.AddNums);
            // Step 3: now call the delegate by passing required parameter values,
            // so that intarnally the method which is bound with the delegate get executed.
            // ad(100,50);
            ad.Invoke(100, 50);

            // SayDelegate sd = new SayDelegate(Program.SayHello);
            SayDelegate sd = new SayDelegate(SayHello);
            // Step 3: now call the delegate by passing required parameter values,
            // so that intarnally the method which is bound with the delegate get executed.
            //string str = sd("Amey");
            string str = sd.Invoke("Amey");
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
