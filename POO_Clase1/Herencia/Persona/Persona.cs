namespace POO_Clase1.Herencia.Persona
{
    public abstract class Persona
    {
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public abstract string Saludar();
    }
}
