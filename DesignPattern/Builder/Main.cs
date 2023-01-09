using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Main
    {
        public static void Example()
        {
            var humanBuilder = new HumanBuilder();
            Human human = humanBuilder.SetAddress(null).SetWeight(5).SetJob("developer").Build();
        }
    }
}
