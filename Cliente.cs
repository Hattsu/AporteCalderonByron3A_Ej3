using System;
namespace Aporte_CalderonByron3A_Ej3
{
    class Cliente:IImprimir
    {   
        public string Nombre {set; get;}
        public string Apellido {set; get;}
        public string Direccion {set; get;}
        public int Cedula_identidad {set; get;}
        public Cliente(string nombre, string apellido, string direccion, int cedula_identidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Cedula_identidad = cedula_identidad;
        }

        public void Mostrar()
        {
            Console.WriteLine(" Ficha: Cliente");
            Console.WriteLine("---------------------");
            Console.WriteLine("Apellido: "+Nombre);
            Console.WriteLine("Apellido: "+Apellido);
            Console.WriteLine("Dirección: "+Direccion);
            Console.WriteLine("Cedula de identidad: "+Cedula_identidad);
            Console.WriteLine("----------------------");
            
        }
    }
}