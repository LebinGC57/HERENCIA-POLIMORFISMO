using p1bpoo.MisClases;
using System;

namespace p1bpoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AutoDeCombustion miAuto = new AutoDeCombustion(2023, "Rojo", "Toyota", 50, "Gasolina");
            Motocicleta miMoto = new Motocicleta(2022, "Negra", "Harley Davidson", 1200, true);
            Camion miCamion = new Camion(2020, "Azul", "Volvo", 10000, true);
            CarroElectrico miCarroElectrico = new CarroElectrico(2025, "Blanco", "Tesla");

            miAuto.InformacionVehiculo();
            miAuto.acelerar(30);
            miAuto.Frenar(); 

            miMoto.InformacionVehiculo();
            miMoto.acelerar(40);
            miMoto.Encender(); 

            miCamion.InformacionVehiculo();
            miCamion.acelerar(20);
            miCamion.Cargar(5000); 

            miCarroElectrico.InformacionVehiculo();
            miCarroElectrico.acelerar(10);
            Console.WriteLine("Nivel de batería: " + miCarroElectrico.NivelBateria());

            Console.ReadLine();
        }
    }
}

