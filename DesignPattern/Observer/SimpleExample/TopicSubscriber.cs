using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.SimpleExample
{
    public class TopicSubscriber : IObserver
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
}
