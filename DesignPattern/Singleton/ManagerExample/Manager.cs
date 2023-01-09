using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton.ManagerExample
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
}
