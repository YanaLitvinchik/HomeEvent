using System;

namespace Tamagotchi
{

    internal class Mama
    {

        int f = 0;
        String state;
        public void Method(String name)
        {
            if (state != name)
            {
                state = name;
                f = 0;
            }
            else     
                f++;               //ddddn
            if (f >= 3)
                SayNo();
            else
                SayYes();
        }        
        internal void SayNo()
        {
            Console.WriteLine("You can't do it more than 3 times!");
        }
        internal void SayYes()
        {
            Console.WriteLine("Okey, do it.");
        }
    }
}