using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.SimpleExample
{
    public class Main
    {
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
