using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Home h = new Home();
            Security s = new Security();
            h.IsSecure = true;

             //  h.Alarm += s.SendCar;
               h.Alarm += s.SendBycicle;

            h.OpenDoor();
            h.IsSecure = false;
            h.OpenWindow();
        }
    }

    internal class Security
    {
        internal void SendBycicle()
        {
            Console.WriteLine("ОТПРАВИЛИ СУПЕР ЗАЩИЩЕННЫЙ ПАТРУЛЬ!");
        }

        internal void SendCar()
        {
            Console.WriteLine("МАЛЬЧИКИ ПО ВЫЗОВУ ВЫЕХАЛИ!!!");
        }
    }
    public delegate void MessageConstructor();
    internal class Home
    {
        public event MessageConstructor Alarm;
        protected virtual void OnAlarm()
        {
            //if (Alarm != null)
            //{
            //    //Alarm();
            //    Alarm.Invoke();
            //}
            Alarm?.Invoke();
        }
        public bool IsSecure { get; set; }
        internal void OpenDoor()
        {
            if (IsSecure)
            {
                OnAlarm();
            }
        }
        internal void OpenWindow()
        {
            if (IsSecure)
            {
                OnAlarm();
            }
        }
    }
}
