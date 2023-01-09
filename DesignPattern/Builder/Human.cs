using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Human
    {
        int money;
        string name;
        float height;
        float weight;
        string address;
        string phone;
        string car;
        string job;
        string hobby;

        public Human(int money, string name, float height, float weight, string address, string phone, string car, string job, string hobby)
        {
            this.money = money;
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.address = address;
            this.phone = phone;
            this.car = car;
            this.job = job;
            this.hobby = hobby;
        }
    }
}
