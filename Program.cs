using System;
namespace Aporte_CalderonByron3A_Ej3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Juan", "López", "Las acacias", 132045434);
            cliente.Mostrar();
            Vehiculo vehiculo = new Vehiculo("Hyundai", "Creta", 2017, 20000);
            vehiculo.Calcular();
        }
    }
}