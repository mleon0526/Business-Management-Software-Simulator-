
using System;

namespace Admin_Page
{
    internal class Compras
    {
        public static void compras()
        {
            string chosenActionCompras = "";

            while (chosenActionCompras != "x")
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al panel de compras.");
                Console.WriteLine();
                Console.WriteLine("nuevaCompra: Generar nueva compra.");
                Console.WriteLine();
                Console.WriteLine("eliminarCompra: Elimina una compra del sistema.");
                Console.WriteLine();
                Console.WriteLine("editarCompra: Editar los detalles de una compra.");
                Console.WriteLine();
                Console.WriteLine("historialCompra: Accede al historial entero de compras.");
                Console.WriteLine();
                Console.WriteLine("chatCompra: Ponte en contacto con cualquier cliente relacionado a una compra.");
                Console.WriteLine();
                Console.WriteLine("reporteCompra: genera un reporte de una compra con asistente IA incluido.");
                Console.WriteLine();
                Console.WriteLine("cerrarCompra: Cerrar el modulo de compras.");
                Console.WriteLine();
                Console.WriteLine("Ingresa 'x' para salir del programa.");
                Console.WriteLine();

                chosenActionCompras = Console.ReadLine();

                switch (chosenActionCompras)
                {

                    case "nuevaCompra":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando nueva compra...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "eliminarCompra":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Eliminando compra del sistema...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "editarCompra":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando compra...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "historialCompra":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chequeando historial...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "chatCompra":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chat abierto...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "reporteCompra":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando reporte de compras...");
                        Principal.WaitForCompletion();
                        Principal.Main();
                        Console.WriteLine();
                        break;

                    case "cerrarCompra":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Cerrando  panel de compras...");
                        Principal.WaitForCompletion();
                        Principal.Main();
                        Console.WriteLine();
                        break;

                    case "x":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Environment.Exit(0);
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