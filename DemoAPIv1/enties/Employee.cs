namespace DemoAPIv1.enties
{
    public class Employee
    {

        String id;
        String name;
        String age;

        public Employee()
        {
        }

        public Employee(string id, string name, string age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public string Id
        {
            get { return id; }
            set => id = value;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
