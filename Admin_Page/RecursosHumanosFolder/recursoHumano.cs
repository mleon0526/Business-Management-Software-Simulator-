
using System;
using Admin_Page.RecursosHumanosFolder;

namespace Admin_Page
{
    internal class RecursoHumano
    {
        public static void Empleados()
        {
            string chosenActionEmpleados = "";

            while (chosenActionEmpleados != "x")
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al panel de Recursos Humanos");
                Console.WriteLine();
                Console.WriteLine("nuevoEmpleado: Crea un nuevo empleado");
                Console.WriteLine();
                Console.WriteLine("eliminarEmpleado: Elimina un empleado dentro del programa");
                Console.WriteLine();
                Console.WriteLine("editarEmpleado: Edita el perfil de un empleado");
                Console.WriteLine();
                Console.WriteLine("nominaEmpleados: Maneja la nomina de tu empresa");
                Console.WriteLine();
                Console.WriteLine("escribirEmpleado: Escribele un mensaje privado a un empleado que sea de importancia o de suma importancia.");
                Console.WriteLine();
                Console.WriteLine("cerrarEmpleado: Cerrar la pagina de detallesEmpleados");
                Console.WriteLine();
                Console.WriteLine("Ingresa 'x' para salir del programa.");
                Console.WriteLine();

                chosenActionEmpleados = Console.ReadLine();

                switch (chosenActionEmpleados)
                {
                    case "nuevoEmpleado":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Agregando Empleado...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "eliminarEmpleado":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("¿Seguro que quieres eliminar el perfil del empleado ?");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "editarEmpleado":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando el perfil de un empleado...");
                        EditarDetallesEmpleados.editarEmpleados();
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "nominaEmpleados":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando la nomina...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "escribirEmpleado":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("¿Deseas mandar el siguiente mensaje ?");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "cerrarEmpleado":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Cerrando el panel de recursos humanos...");
                        Principal.Main();
                        Console.WriteLine();
                        break;

                    case "x":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Saliendo del programa...");
                        Environment.Exit(0);
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Error: Asegurate de que el comando este bien escrito.");
                        Console.WriteLine();
                        break;
                }
            }

            Environment.Exit(0); //exit program when x clicked

        }

    }
}