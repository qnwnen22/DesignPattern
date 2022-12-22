using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Singleton
    {
        public class Manager
        {
            private static Manager manager;

            public string name;

            public static Manager Instance
            {
                get
                {
                    if (manager == null)
                    {
                        manager = new Manager();
                    }
                    return manager;
                }
            }
            private Manager() { }
        }

        public static void Example()
        {
            Manager m1 = Manager.Instance;
            Manager m2 = Manager.Instance;

            m1.name = "필드 초기화";
            Console.WriteLine($"m1 : {m1.name}");

            m2.name = "필드 수정";
            Console.WriteLine($"m1 : {m1.name}");
            Console.WriteLine($"m2 : {m2.name}");
        }
    }
}
