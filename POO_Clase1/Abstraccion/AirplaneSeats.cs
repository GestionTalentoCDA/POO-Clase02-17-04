namespace POO_Clase1.Abstraccion
{
    public class AirplaneSeats
    {
        public int[] Seats { get; set; }

        public AirplaneSeats( int[] seats )
        {
            this.Seats = seats;
        }

        //[1, 2, 3, 4, 5]
        // reserva el asiento 3
        // [1, 2, 0, 4, 5]
        public void ReserveSeat( int seat )
        {
            for (int i = 0; i < Seats.Length; i++)
            {
                if (Seats[i] == seat)
                {
                    Seats[i] = 0;
                }
            }
            Console.WriteLine( $"El asiento {seat} ha sido reservado" );
        }

        public void PrintSeats()
        {
            foreach (int item in Seats)
            {
                Console.Write( $"|{item}" );
            }
            Console.WriteLine();
        }
    }
}
