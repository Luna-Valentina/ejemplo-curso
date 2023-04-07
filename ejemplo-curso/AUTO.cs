using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_AUTO
{
    internal class AUTO
    {

        #region Atributos
        private string Marca;
        private string Modelo;
        private int Anio;
        private double Motor;
        private int CantidadPuertas;
        private double Combustible;
        private double Capacidad;
        private double Reserva;
        #endregion

        #region Properties
        public string marca { get => Marca; }
        public string modelo { get => Modelo; }
        public int anio { get => Anio; }
        public double motor { get => Motor; }
        public int cantidadPuertas { get => CantidadPuertas; }
        public double combustible { get => Combustible; set => Combustible = value; }
        public double capacidad { get => Capacidad; }
        public double reserva { get => Reserva; set => Reserva = value; }
        #endregion

        #region Métodos
        public string conducir(float kilometros)
        {
            float combustibleNecesario = kilometros / 11; //11 KM POR LITRO RECORRIDO
            if (combustibleNecesario <= Combustible + 5) 
            {
                Combustible -= combustibleNecesario;
                return "Los kilómetros pueden ser recorridos. Usted aún dispone de " + Combustible.ToString("0.00") + " litros de combustible.";
            }
            else return "No es posible recorrer los kilómetros ingresados. No dispone del combustible necesario";
        }

        public string cargarCombustible(double litros)
        {
            double litrosDerramados = 49.00;

           // litros CANTIDAD QUE CARGO
           // combustible lo que tiene cargado
            while (litros > 0 && Combustible <= 49.00)
            {

                litros--;
                Combustible++;

                
                
               

            }
            litrosDerramados = litros;
            return "Combustible recargado. En la recarga se derramaron " + litrosDerramados + " litros. Ahora usted dispone de " + combustible.ToString("0.00") + " litros en su tanque y una reserva de " + reserva + " litros.";
        }
        #endregion

        #region Constructora
        public AUTO(string marca, string modelo, int anio, float motor, int cantidadPuertas, double combustible)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Motor = motor;
            CantidadPuertas = cantidadPuertas;
            Combustible = combustible;
            Capacidad = 49;
            Reserva = 5;
        }
        #endregion

    }
}
