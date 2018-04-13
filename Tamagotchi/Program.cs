using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Game a = new Game();
            Mama m = new Mama();
            a.M += m.Method;
           
            a.Sleep();
            a.Sleep();
            a.Sleep();
            a.Sleep();
            a.Sleep();
            a.Sleep();
            a.Treat();
            a.Treat();
            a.Play();
            a.Play();
            a.Treat();
            a.Treat();
            a.Treat();
            a.Treat();
            a.Treat();
            a.Treat();
            a.Treat();


        }
    }
}
