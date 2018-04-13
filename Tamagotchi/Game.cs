using System;

namespace Tamagotchi
{
    public delegate void Message2_0(String str);
    internal class Game
    {      
        
        public event Message2_0 M;

        protected virtual void  On(String s)
        {
            if(s == "Feed")
            {
                M?.Invoke(s);
            }
            if (s == "Sleep")
            {
                M?.Invoke(s);
            }
            if (s == "Treat")
            {
                M?.Invoke(s);
            }
            if (s == "Play")
            {
                M?.Invoke(s);
            }

        }
        #region onsomething
       
        //----------------------
        internal void Feed()
        {
            On("Feed");
        }
        internal void Sleep()
        {
            On("Sleep");
        }
        internal void Treat()
        {
            On("Treat");
        }
        internal void Play()
        {
            On("Play");
        }
        #endregion 

    }
}