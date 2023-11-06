namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (base.Age <= 15)
                {
                    base.Age = value;
                }
            }
        }
    }
}