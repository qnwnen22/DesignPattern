using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Observer
    {
        private interface IObserver
        {
            void Update();
        }

        private interface ISubject
        {
            void Register(IObserver observer);
            void Unregister(IObserver observer);
            void Notify();
            object GetUpadte(IObserver observer);
        }

        private class Topic : ISubject
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

        private class TopicSubscriber : IObserver
        {
            private string name;

            private ISubject topic;

            public TopicSubscriber(string name, ISubject topic)
            {
                this.name = name;
                this.topic = topic;
            }

            public void Update()
            {
                string msg = topic.GetUpadte(this).ToString();
                Console.WriteLine($"{name} :: got message >> {msg}");
            }
        }

        public static void Example()
        {
            Topic topic = new Topic();
            topic.Register(new TopicSubscriber("a", topic));
            topic.Register(new TopicSubscriber("b", topic));
            topic.Register(new TopicSubscriber("c", topic));

            topic.postMessage("post message");
        }
    }
}
