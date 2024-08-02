using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransRiwi.Models;
using TransRiwi.Views;

namespace TransRiwi.Controllers
{
    public class MainController
    {
        ViewConsole _view = new ViewConsole();
        CollectionMain _app = new CollectionMain();

        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                int mainOption = _view.ShowMainManu();
                switch (mainOption)
                {
                    case 1:
                        ManageDrivers();
                        break;
                    case 2:
                        ManageCustomers();
                        break;
                    case 3:
                        ManageVehicle();
                        break;
                    case 5:
                        exit = true;
                        break;
                }
            }

            _view.ShowMessage("Gracias por usar el sistema de Gestion Escolar");
        }

        private void ManageDrivers()
        {
            bool back = false;
            while (!back)
            {
                int option = _view.ShowDriverMenu();
                switch (option)
                {
                    case 1:
                        AddDriver();
                        break;
                    case 2:
                        EditDriver();
                        break;
                    case 3:
                        DeleteDriver();
                        break;
                    case 4:
                        ShowDrivers();
                        break;
                    case 5:
                        back = true;
                        break;
                }
            }
        }

        private void ManageCustomers()
        {
            bool back = false;
            while (!back)
            {
                int option = _view.ShowCustomerMenu();
                switch (option)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        EditCustomer();
                        break;
                    case 3:
                        DeleteCustomer();
                        break;
                    case 4:
                        ShowCustomers();
                        break;
                    case 5:
                        back = true;
                        break;
                }
            }
        }

         private void ManageVehicle()
        {
            bool back = false;
            while (!back)
            {
                int option = _view.ShowCustomerMenu();
                switch (option)
                {
                    case 1:
                        AddVehicle();
                        break;
                    case 2:
                        EditVehicle();
                        break;
                    case 3:
                        DeleteVehicle();
                        break;
                    case 4:
                        ShowVehicles();
                        break;
                    case 5:
                        back = true;
                        break;
                }
            }
        }

        //Methods de agregar 
        private void AddCustomer()
        {
            Customer newCustomer = _view.GetCustomerInfo();
            _app.AddCustomer(newCustomer);
            _view.ShowMessage("Cliente agregado con exito");
        }
        private void AddVehicle()
        {
            // Customer newVehicle = _view.GetCustomerInfo();
            // _app.AddVehicle(newVehicle);
            // _view.ShowMessage("Vehiculo agregado con exito");
        }
        private void AddDriver()
        {
            Driver newDriver = _view.GetDriverInfo();
            _app.AddDriver(newDriver);
            _view.ShowMessage("Conductor agregado con exito");
        }
        //Implementacion metodos para mostrar informacion
        private void ShowCustomers()
        {
            _app.ShowCustomers();
            _view.ShowMessage("---------------------------");
        }
        private void ShowDrivers()
        {
            _app.ShowDrivers();
            _view.ShowMessage("---------------------------");
        }
        private void ShowVehicles()
        {
            _app.ShowVehicle();
            _view.ShowMessage("---------------------------");
        }

        //Implementacion metodos para eliminar
        private void DeleteCustomer()
        {
            Guid id = _view.GetIdForAction("Eliminar");
            Customer customer = _app.customers.FirstOrDefault(c => c.GetId() == id);
            if (customer != null)
            {
                _app.customers.Remove(customer);
                _view.ShowMessage("Cliente eliminado con éxito.");
            }
            else
            {
                _view.ShowMessage("cliente no encontrado.");
            }
        }
        private void DeleteDriver()
        {
            Guid id = _view.GetIdForAction("Eliminar");
            Driver driver = _app.drivers.FirstOrDefault(c => c.GetId() == id);
            if (driver != null)
            {
                _app.drivers.Remove(driver);
                _view.ShowMessage("Conductor eliminado con éxito.");
            }
            else
            {
                _view.ShowMessage("Conductor no encontrado.");
            }
        }
        private void DeleteVehicle()
        {
            // Guid id = _view.GetIdForAction("Eliminar");
            // Customer customer = _app.customers.FirstOrDefault(c => c.GetId() == id);
            // if (customer != null)
            // {
            //     _app.customers.Remove(customer);
            //     _view.ShowMessage("Conductor eliminado con éxito.");
            // }
            // else
            // {
            //     _view.ShowMessage("Conductor no encontrado.");
            // }
        }

        private void EditCustomer()
        {
            Guid id = _view.GetIdForAction("Editar");
            Customer customer = _app.customers.FirstOrDefault(c => c.GetId() == id);
            if (customer != null)
            {
                Customer updatedCustomer = _view.GetCustomerInfo(customer);
                _view.ShowMessage("Cliente Actualziado con exito");
            }
            else
            {
                _view.ShowMessage("Cliente no encontrado");
            }
        }
        private void EditDriver()
        {
            Guid id = _view.GetIdForAction("Editar");
            Driver driver = _app.drivers.FirstOrDefault(c => c.GetId() == id);
            if (driver != null)
            {
                Driver updatedDriver = _view.GetDriverInfo(driver);
                _view.ShowMessage("Conductor Actualziado con exito");
            }
            else
            {
                _view.ShowMessage("Conductor no encontrado");
            }
        }
        private void EditVehicle()
        {
            Guid id = _view.GetIdForAction("Editar");
            Customer customer = _app.customers.FirstOrDefault(c => c.GetId() == id);
            if (customer != null)
            {
                Customer updatedCustomer = _view.GetCustomerInfo(customer);
                _view.ShowMessage("Cliente Actualziado con exito");
            }
            else
            {
                _view.ShowMessage("Cliente no encontrado");
            }
        }
    }
}