using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioMan;

namespace OOP.ConsoleAct
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            while (i < 10) 
            {
                Console.WriteLine("Escribe el Vehículo");

                String vehicleType = Console.ReadLine().ToLower();

                Vehiculo vehicle = null;

                switch (vehicleType) 
                {
                    case "camion":
                        vehicle = new Camion();
                        break;
                    case "tren":
                        vehicle = new Tren();
                        break;
                    case "automovil":
                        vehicle = new Automovil();
                        break;
                    default:
                        Console.WriteLine("Vehiculo no encontrado");
                        break;
                }

                if (vehicle != null) 
                {
                    vehicle.VehiculoAudio();
                }

                i++;
            }

            Console.ReadKey();

        }
    }
}
