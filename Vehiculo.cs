using System;
namespace Aporte_CalderonByron3A_Ej3
{
    class Vehiculo:IImprimir2
    {
        public string Marca {set; get;}
        public string Modelo {set; get;}
        public int Año_fabricacion {set; get;}
        public double Precio_venta {set; get;}
        public Vehiculo(string marca, string modelo, int año_fabricacion, double precio_venta)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Año_fabricacion= año_fabricacion;
            this.Precio_venta = precio_venta;
        }
        public void Calcular()
        {
            double  Impuesto_ambiente = 0, Impuesto_iva = 0;
            int porcentaje=0;
            if(Año_fabricacion<=2015)
            {
                Impuesto_ambiente = Precio_venta + (Precio_venta*0.10);
                porcentaje = 10;
            }else{
                Impuesto_ambiente = Precio_venta + (Precio_venta*0.02);
                porcentaje = 2;
            }
            Impuesto_iva = Impuesto_ambiente + (Impuesto_ambiente*0.12);
            Mostrar(Impuesto_ambiente, Impuesto_iva, porcentaje);
        }
        public void Mostrar(double Impuesto_ambiente, double Impuesto_iva, int porcentaje)
        {
            Console.WriteLine(" Ficha: Vehiculo");
            Console.WriteLine("---------------------");
            Console.WriteLine("Marca: "+Marca);
            Console.WriteLine("Modelo: "+Modelo);
            Console.WriteLine("Año de fabricación: "+Año_fabricacion);
            Console.WriteLine("Precio de venta sin impuestos: "+Precio_venta);
            Console.WriteLine("Precio de venta agregando -> impuesto ambiental ("+porcentaje+"%): "+Impuesto_ambiente);
            Console.WriteLine("Precio de venta agregando -> impuesto iva (12%): "+Impuesto_iva);
            Console.WriteLine("---------------------");
        }
    }
}