using System;

namespace Propiedades_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleados hamel = new Empleados("Hamel", "Zabala", 19);

            //modificando el campo encapsulado 'sueldo' mediante la propiedad 'SUELDO'
            hamel.SUELDO = 10000;

            //llamando al metodo GetDatosEmpleados para mostrar los datos del empleado
            hamel.GetDatosEmpleados();
            
            Console.WriteLine($"El salario del empleado es de US${hamel.SUELDO}");
        }
    }
    class Empleados
    {
        private string nombre;
        private string apellido;
        private int edad;
        private double sueldo;

        public Empleados(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        
        public void GetDatosEmpleados()
        {
            Console.WriteLine("Nombre del empleado: " + this.nombre + " " + this.apellido);
            Console.WriteLine("Edad: " + this.edad);
        }

        //método que debe cumplir la propiedad SUELDO
        private double evaluacionDeSueldo(double sueldo)
        {
            
            if (sueldo < 0) return 0;
            

            else return sueldo;
        }

        /*creación de propiedad para modificar y acceder al 
          campo de clase privado 'sueldo' desde cualquier parte del programa*/
        public double SUELDO
        {
            get { return this.sueldo; }
            
            set { this.sueldo = evaluacionDeSueldo(value); }
        }
        
    }
}
