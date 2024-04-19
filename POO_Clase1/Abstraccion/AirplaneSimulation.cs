namespace POO_Clase1.Abstraccion
{
    public class AirplaneSimulation
    {
        public int Speed { get; set; }
        public int Altitude { get; set; }
        public int Angle { get; set; }

        public AirplaneSimulation()
        {

        }
        public void Fly()
        {
            Console.WriteLine( "El avion está volando" );
        }
    }
}
