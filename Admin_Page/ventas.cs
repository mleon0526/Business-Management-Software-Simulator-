
using System;

namespace Admin_Page
{
    internal class Ventas
    {
        public static void ventas()
        {
            string chosenActionVentas = "";

            while (chosenActionVentas != "x")
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al panel de ventas");
                Console.WriteLine();
                Console.WriteLine("nuevaVenta: Generar una nueva venta");
                Console.WriteLine();
                Console.WriteLine("eliminarVenta: Elimina una venta dentro del programa.");
                Console.WriteLine();
                Console.WriteLine("editarVenta: Editar los detalles de una venta.");
                Console.WriteLine();
                Console.WriteLine("facturarVenta: Genera una factura para una venta.");
                Console.WriteLine();
                Console.WriteLine("mensajeVenta: Abrir chat con el cliente.");
                Console.WriteLine();
                Console.WriteLine("cerrarVenta: Cerrar el modulo de venta");
                Console.WriteLine();
                Console.WriteLine("Ingresa 'x' para salir del programa.");
                Console.WriteLine();

                chosenActionVentas = Console.ReadLine();

                switch (chosenActionVentas)
                {

                    case "nuevaVenta":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando nueva venta...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "eliminarVenta":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Eliminando venta...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "editarVenta":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando venta...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "facturarVenta":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando factura de venta...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "mensajeVenta":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chat Abierto...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "cerrarVenta":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Cerrando  venta...");
                        Principal.WaitForCompletion();
                        Principal.Main();
                        Console.WriteLine();
                        break;

                    case "x":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Saliendo del programa...");
                        Environment.Exit(0);
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Error: asegurate de escribir bien el comando");
                        break;
                }

            }

            Environment.Exit(0); //exit program when x clicked

        }
    }
}
