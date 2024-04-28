namespace SRP
{
    public abstract class Persona
    {
        private string nombre;
        private string edad;
        private string direccion;
        private string correoElectronico;

        public Persona (string nombre, string edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }

        public virtual void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion:{direccion}");
            Console.WriteLine($"Correo electronico: {correoElectronico}");
        }
    }
}
