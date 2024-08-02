using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Views
{
    public class ViewConsole
    {
        //Vistas para el usuario
        public int ShowMainManu()
        {
            System.Console.Clear();
            Console.WriteLine("=== Sistema de Transporte Riwi ===");
            Console.WriteLine("1. Gestionar Conductor");
            Console.WriteLine("2. Gestionar Cliente");
            Console.WriteLine("3. Gestionar Vehiculo");
            Console.WriteLine("4. Realizar Consultas");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                System.Console.Write("Invalid Option, Try Again: ");
            }
            return opcion;
        }

        public int ShowDriverMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Conductores ===");
            Console.WriteLine("1. Agregar Condutor");
            Console.WriteLine("2. Editar Condutor");
            Console.WriteLine("3. Eliminar Condutor");
            Console.WriteLine("4. Mostrar Condutores");
            Console.WriteLine("5. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                System.Console.Write("Invalid Option, Try Again: ");
            }
            return opcion;
        }

        public int ShowCustomerMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Clientes ===");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Editar Cliente");
            Console.WriteLine("3. Eliminar Cliente");
            Console.WriteLine("4. Mostrar Clientes");
            Console.WriteLine("5. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                System.Console.Write("Invalid Option, Try Again: ");
            }
            return opcion;
        }

        public int ShowVehicleMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Vehiculos ===");
            Console.WriteLine("1. Agregar Vehiculo");
            Console.WriteLine("2. Editar Vehiculo");
            Console.WriteLine("3. Eliminar Vehiculo");
            Console.WriteLine("4. Mostrar Vehiculos");
            Console.WriteLine("5. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                System.Console.Write("Invalid Option, Try Again: ");
            }
            return opcion;
        }

        //Solicitar un id para editar o eliminar
        public Guid GetIdForAction(string action)
        {
            System.Console.Write($"Ingresa el id del registro a {action}: ");
            Guid id;
            while (!Guid.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Id invalido. Intente de nuevo: ");
            }
            return id;
        }

        //Monstrar mensaje y esperar confirmacion del usuario
        public void ShowMessage(string mensaje)
        {
            System.Console.WriteLine(mensaje);
            System.Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}