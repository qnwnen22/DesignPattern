using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.SimpleExample
{
    public class Topic : ISubject
    {
        List<IObserver> observers;
        private string message;

        public Topic()
        {
            this.observers = new List<IObserver>();
            this.message = "";
        }

        public void Register(IObserver observer)
        {
            if (observer != null)
            {
                observers.Add(observer);
            }
        }
        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            observers.ForEach((observer) =>
            {
                observer.Update();
            });
        }
        public object GetUpadte(IObserver observer)
        {
            return message;
        }

        public void postMessage(string msg)
        {
            Console.WriteLine($"Message sended to Topic : " + msg);
            message = msg;
            Notify();
        }
    }
}
