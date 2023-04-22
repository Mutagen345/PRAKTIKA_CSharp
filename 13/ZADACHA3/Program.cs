using System;

namespace EventHandling
{
    public delegate void EventHandler(object sender, EventArgs e);

    public class MyClass
    {
        public event EventHandler MyEvent;

        public void RaiseEvent()
        {
            Console.WriteLine("Event raised");
            OnMyEvent(EventArgs.Empty);
        }

        protected virtual void OnMyEvent(EventArgs e)
        {
            MyEvent?.Invoke(this, e);
        }
    }

    public class Observer1
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Observer1: Event handled");
        }
    }

    public class Observer2
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Observer2: Event handled");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            myClass.MyEvent += observer1.HandleEvent;
            myClass.MyEvent += observer2.HandleEvent;
            myClass.MyEvent += observer1.HandleEvent;

            myClass.RaiseEvent();

            myClass.MyEvent -= observer1.HandleEvent;

            myClass.RaiseEvent();

            Console.ReadLine();
        }
    }
}
