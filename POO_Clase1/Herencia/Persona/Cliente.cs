namespace POO_Clase1.Herencia.Persona
{
    public class Cliente : Persona
    {
        public string CodCliente { get; set; }

        public override string Saludar()
        {
            return "Hola, soy un cliente.";
        }
    }
}
