using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Builder
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

        private class HumanBuilder
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

            public HumanBuilder() { }

            public HumanBuilder SetMoney(int money)
            {
                this.money = money;
                return this;
            }

            public HumanBuilder SetName(string name)
            {
                this.name = name;
                return this;
            }

            public HumanBuilder SetHeight(float height)
            {
                this.height = height;
                return this;
            }

            public HumanBuilder SetWeight(float weight)
            {
                this.weight = weight;
                return this;
            }

            public HumanBuilder SetAddress(string address)
            {
                this.address = address;
                return this;
            }

            public HumanBuilder SetPhone(string phone)
            {
                this.phone = phone;
                return this;
            }

            public HumanBuilder SetCar(string car)
            {
                this.car = car;
                return this;
            }

            public HumanBuilder SetJob(string job)
            {
                this.job = job;
                return this;
            }

            public HumanBuilder SetHobby(string hobby)
            {
                this.hobby = hobby;
                return this;
            }

            public Human Build()
            {
                return new Human(money, name, height, weight, address, phone, car, job, hobby);
            }
        }


        public static void Example()
        {
            var humanBuilder = new HumanBuilder();
            Human human = humanBuilder.SetAddress(null).SetWeight(5).SetJob("developer").Build();
        }
    }
}
