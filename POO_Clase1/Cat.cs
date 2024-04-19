namespace POO_Clase1
{
    public class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Cat( string name, string color, int age )
        {
            Name = name;
            Color = color;
            Age = age;
        }

        public string Eat()
        {
            return "Estoy comiendo";
        }

    }
}
