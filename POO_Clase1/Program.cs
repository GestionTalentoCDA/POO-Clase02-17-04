using POO_Clase1.Herencia.Persona;

namespace POO_Clase1
{
    internal class Program
    {
        static void Main( string[] args )
        {
            #region Intro
            //Console.WriteLine( "Hello, World!" );

            /*
             * fdsa
             * fsaga
             */

            //VARIABLES

            //int variable1;
            //variable1 = 12;

            //Console.WriteLine( variable1 );

            //string variable2 = "12";
            //Console.WriteLine( variable2 );


            //int variable3 = 13;

            //Console.WriteLine( variable3 + variable1 ); //SUma de enteros

            //string variable4 = "14";

            //Console.WriteLine( variable4 + variable2 );

            //Condicionales IF

            //int x = 10;
            //int y = 10;

            //if (x < y)
            //{
            //    Console.WriteLine( x + " es menor que " + y );
            //}
            //else if (x == y)
            //{
            //    Console.WriteLine( x + " es igual que " + y );
            //}
            //else
            //{
            //    Console.WriteLine( x + " es mayor que " + y );
            //}


            //Listas, Arrays y Ciclos For

            //int[] miPrimerArray = { 10, 11, 12 };

            //Console.WriteLine( miPrimerArray[3] );

            //for (int i = 0; i < miPrimerArray.Length; i++)
            //{
            //    Console.WriteLine( miPrimerArray[i] );
            //}

            //List<string> miPrimeraLista = new List<string>() { "abc", "def" };

            ////miPrimeraLista.Add( 28 );

            //Console.WriteLine( miPrimeraLista.Count );

            //foreach (string palabra in miPrimeraLista)
            //{
            //    Console.WriteLine( palabra );
            //}


            #endregion

            #region Clases y objetos

            //int miNumero = 3;

            //Cat miGato = new Cat( "michi", "negro", 2 );
            //Cat otroGato = new Cat( "Garfield", "Naranja", 3 );

            //Console.WriteLine( miGato.Name + miGato.Color + miGato.Age );


            #endregion

            #region Abstraccion

            //AirplaneSimulation miAvion = new AirplaneSimulation()
            //{
            //    Altitude = 10000,
            //    Angle = 180,
            //    Speed = 1200
            //};

            //miAvion.Fly();
            //Console.WriteLine( miAvion.Altitude );

            //int[] asientos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //AirplaneSeats seats = new AirplaneSeats( asientos );

            //seats.PrintSeats();

            //seats.ReserveSeat( 8 );
            //seats.ReserveSeat( 1 );
            //seats.ReserveSeat( 3 );

            //seats.PrintSeats();

            #endregion

            #region Herencia

            //Vehiculo v = new Vehiculo();
            //v.Marca = "MB";
            //v.VelocidadMaxima = 200;
            //v.Modelo = "Camion";

            //Coche coche = new Coche();
            //coche.Marca = "Ford";
            //coche.Modelo = "Fiesta";
            //coche.VelocidadMaxima = 220;
            //coche.Traccion = "Delantera";

            //Motocicleta moto = new Motocicleta();
            //moto.Marca = "Yamaha";
            //moto.Modelo = "FZ";
            //moto.VelocidadMaxima = 300;
            //moto.Cilindrada = 150;

            //Persona empleado = new Persona()
            //{
            //    Apellido = "Mossier",
            //    Nombre = "Fernando",
            //    Direccion = "Calle falsa 123"
            //};

            //Console.WriteLine( empleado.Apellido );

            //Console.WriteLine( empleado.Saludar() );

            Cliente cliente1 = new Cliente()
            {
                Apellido = "Jara",
                Nombre = "Ale",
                Direccion = "direccion1",
                CodCliente = "9999abc123"
            };

            //Console.WriteLine( $"soy {cliente1.Nombre}. {cliente1.Saludar()}" );

            Proveedor prov = new Proveedor()
            {
                Apellido = "Carreras",
                Nombre = "Alexis",
                Direccion = "123"
            };

            //Console.WriteLine( prov.Saludar() );

            //Persona persona = new Persona()
            //{
            //    Apellido = "Fernando"
            //};

            Console.WriteLine( prov.Saludar() );
            Console.WriteLine( cliente1.Saludar() );





            #endregion

            Console.ReadKey();

        }
    }
}