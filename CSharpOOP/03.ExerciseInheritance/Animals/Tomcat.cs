﻿
namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {
            this.Gender = "Male";
        }

        public Tomcat(string name, int age):base(name,age)
        {
            this.Gender = "Male";
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
